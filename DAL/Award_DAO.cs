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
    public class Award_DAO : Award_Interface_DAO
    {
        private string _connectionString = @"Data Source=DESKTOP-JP2LHIO;Initial Catalog=Users_Ismaylova;Integrated Security=True";
        public void Add(Award value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addAward";
                cmd.Parameters.AddWithValue(@"Title", value.Title);
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
        public void AddUserAward(int ID_User, int ID_Award)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addUserAward";
                cmd.Parameters.AddWithValue(@"ID_User", ID_User);
                cmd.Parameters.AddWithValue(@"ID_Award", ID_Award);
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
        public IEnumerable<Award> GetAllUserAndAward(int ID)
        {
            List<Award> award = new List<Award>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllAwardAndUsers";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    award.Add(new Award
                    {
                        ID = (int)reader["Номер награды"],
                        Title = (string)reader["Награды"]
                    });
                }
            }
            return award;
        }
       

        public IEnumerable<Award> GetAll()
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllAward";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    awards.Add(new Award
                    {
                        ID = (int)reader["ID"],
                        Title = (string)reader["Title"]
                    });
                }
            }
            return awards;
        }
      

    }
}
