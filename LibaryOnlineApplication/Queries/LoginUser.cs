using LibaryOnlineApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryOnlineApplication.Queries
{
    public class LoginUser
    {
        public LoginModel checkLogin(string email, string password)
        {
            LoginModel matchingData = new LoginModel();
            using (SqlConnection conn = Database.getConnection())
            {
                string querySql = "SELECT * FROM students WHERE email =@email AND password =@password";
                SqlCommand cmd = new SqlCommand(querySql, conn);
                // truyen tham so
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open(); // mo ket noi
                // thuc thi cau lenh sql
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // do du lieu tu table database sang modle Login
                        matchingData.id = reader["id"].ToString();
                        matchingData.roleId = reader["role_id"].ToString();
                        matchingData.email = reader["email"].ToString();
                        matchingData.phone = reader["phone"].ToString();
                        matchingData.address = reader["address"].ToString();
                        matchingData.fullName = reader["fullname"].ToString();
                        matchingData.code = reader["code"].ToString();
                    }
                    conn.Close(); // dong ket noi(giai phong tai nguyen)
                }
            }
            return matchingData;
        }
    }
}
