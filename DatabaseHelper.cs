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