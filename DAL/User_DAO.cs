using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_DAO : User_Interface_DAO
    {
        private string _connectionString = @"Data Source=DESKTOP-JP2LHIO;Initial Catalog=Users_Ismaylova;Integrated Security=True";
        public void Add(User<int> value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addUser";
                cmd.Parameters.AddWithValue(@"Name", value.Name);
                cmd.Parameters.AddWithValue(@"Date", value.DateOfBrith);
                cmd.Parameters.AddWithValue(@"Age", value.Age);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User<string>> GetAll()
        {
            List<User<string>> users = new List<User<string>>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllUser";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User<string>
                    {
                        ID = (int)reader["ID"],
                        Name = (string)reader["Name"],
                        DateOfBrith = (DateTime)reader["DateOfBirth"],
                        Age = (int)reader["Age"]
                    });
                }
            }
            return users;
        }

        public void RemoveUser(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveUser";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
