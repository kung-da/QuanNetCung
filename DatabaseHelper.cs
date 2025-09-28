using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanNetCung
{
    public static class DatabaseHelper
    {
        // Chuỗi kết nối, thay đổi theo server của bạn
        private static string connectionString = @"Server=localhost;Database=QuanNetDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;";

        // Thông tin người dùng & vai trò hiện tại (cache sau khi đăng nhập)
        public static string CurrentUsername { get; private set; } = string.Empty;
        public static UserRole CurrentRole { get; private set; } = UserRole.Unknown;

        public enum UserRole
        {
            Unknown = 0,
            Admin = 1,
            NhanVien = 2,
            HoiVien = 3
        }

        // Phương thức để lấy kết nối
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Phương thức để thực hiện query SELECT và trả về DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlEx) when (sqlEx.Message.Contains("permission was denied"))
                {
                    // Extract object name từ SQL error message  
                    string objectName = "Unknown Object";
                    if (sqlEx.Message.Contains("object '"))
                    {
                        try
                        {
                            int startIndex = sqlEx.Message.IndexOf("object '") + 8;
                            int endIndex = sqlEx.Message.IndexOf("'", startIndex);
                            if (startIndex > 7 && endIndex > startIndex)
                            {
                                objectName = sqlEx.Message.Substring(startIndex, endIndex - startIndex);
                            }
                        }
                        catch { }
                    }
                    
                    ShowPermissionDenied("Truy vấn dữ liệu", objectName);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Phương thức để thực hiện non-query (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx) when (sqlEx.Message.Contains("permission was denied"))
                {
                    // Extract object name từ SQL error message  
                    string objectName = "Unknown Object";
                    if (sqlEx.Message.Contains("object '"))
                    {
                        try
                        {
                            int startIndex = sqlEx.Message.IndexOf("object '") + 8;
                            int endIndex = sqlEx.Message.IndexOf("'", startIndex);
                            if (startIndex > 7 && endIndex > startIndex)
                            {
                                objectName = sqlEx.Message.Substring(startIndex, endIndex - startIndex);
                            }
                        }
                        catch { }
                    }
                    
                    ShowPermissionDenied("Cập nhật dữ liệu", objectName, sqlEx.Message);
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return -1;
                }
            }
        }

        // Phương thức để gọi Stored Procedure và trả về DataTable
        public static DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlEx) when (sqlEx.Message.Contains("permission was denied"))
                {
                    // Extract object name từ SQL error message  
                    string objectName = "Unknown Object";
                    if (sqlEx.Message.Contains("object '"))
                    {
                        try
                        {
                            int startIndex = sqlEx.Message.IndexOf("object '") + 8;
                            int endIndex = sqlEx.Message.IndexOf("'", startIndex);
                            if (startIndex > 7 && endIndex > startIndex)
                            {
                                objectName = sqlEx.Message.Substring(startIndex, endIndex - startIndex);
                            }
                        }
                        catch { }
                    }
                    
                    ShowPermissionDenied("Truy vấn dữ liệu", objectName);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Phương thức để gọi Stored Procedure non-query
        public static int ExecuteStoredProcedureNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx) when (sqlEx.Message.Contains("permission was denied"))
                {
                    ShowPermissionDenied("Thực thi thủ tục", procedureName, sqlEx.Message);
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return -1;
                }
            }
        }

        // Phương thức để gọi Scalar Function
        public static object ExecuteScalarFunction(string functionName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT dbo.{functionName}({string.Join(",", parameters?.Select(p => "@" + p.ParameterName) ?? new string[0])})", conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
                catch (SqlException sqlEx) when (sqlEx.Message.Contains("permission was denied"))
                {
                    ShowPermissionDenied("Gọi hàm", functionName, sqlEx.Message);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Phương thức để thiết lập server
        public static void SetServer(string server)
        {
            connectionString = $"Server={server};Database=QuanNetDB;Trusted_Connection=True;";
        }

        // Phương thức để thiết lập user (thay đổi connection string)
        public static void SetUser(string username, string password)
        {
            connectionString = $"Server=localhost;Database=QuanNetDB;User Id={username};Password={password};MultipleActiveResultSets=true;";
            CurrentUsername = username;
            CurrentRole = UserRole.Unknown; // reset trước khi detect
        }



        // Method thống nhất để hiển thị thông báo phân quyền đầy đủ
        public static void ShowPermissionDenied(string action = "", string objectName = "", string sqlError = "")
        {
            string roleText = CurrentRole switch
            {
                UserRole.Admin => "Quản trị viên",
                UserRole.NhanVien => "Nhân viên", 
                UserRole.HoiVien => "Hội viên",
                _ => "Không xác định"
            };

            string message = "⚠️ CẢNH BÁO PHÂN QUYỀN\n\n";
            message += "🚫 KHÔNG ĐỦ QUYỀN TRUY CẬP\n\n";
            
            if (!string.IsNullOrEmpty(action))
                message += $"📋 Thao tác: {action}\n";
                
            if (!string.IsNullOrEmpty(objectName))
                message += $"🎯 Đối tượng: {objectName}\n";
                
            message += $"👤 Người dùng: {CurrentUsername}\n" +
                      $"🔑 Vai trò hiện tại: {roleText}\n";

            // Hiển thị thông tin SQL error nếu có
            if (!string.IsNullOrEmpty(sqlError))
            {
                message += $"\n🔍 Chi tiết lỗi SQL:\n{sqlError}\n";
            }

            message += "\n💡 Vui lòng liên hệ quản trị viên để được cấp quyền!";

            MessageBox.Show(message, "Cảnh báo phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Phát hiện role bằng IS_ROLEMEMBER các role ứng dụng
        public static void DetectRole()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"SELECT CASE 
 WHEN IS_ROLEMEMBER('rl_admin') = 1 THEN 'Admin'
 WHEN IS_ROLEMEMBER('rl_nhanvien') = 1 THEN 'NhanVien'
 WHEN IS_ROLEMEMBER('rl_hoivien') = 1 THEN 'HoiVien'
 ELSE 'Unknown' END", conn);
                    var roleStr = (cmd.ExecuteScalar() ?? "Unknown").ToString();
                    CurrentRole = roleStr switch
                    {
                        "Admin" => UserRole.Admin,
                        "NhanVien" => UserRole.NhanVien,
                        "HoiVien" => UserRole.HoiVien,
                        _ => UserRole.Unknown
                    };
                }
            }
            catch (Exception ex)
            {
                CurrentRole = UserRole.Unknown;
                MessageBox.Show("Không thể xác định vai trò: " + ex.Message, "Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}