using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL.NET.Class
{
    public static class Functions
    {
        private static SqlConnection connection;

        public static void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-S0TIEV7;Initial Catalog=QLcuahangquanao;Integrated Security=True;Encrypt=False"; // Thay bằng chuỗi kết nối của bạn
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        public static void dongketnoi()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}