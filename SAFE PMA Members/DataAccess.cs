using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public List<Member> MemberList(string lastName)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            //var output = connection.Query<Member>($"select * from members where lastName = '{lastName}'").ToList();
            MySqlParameter[] pms = new MySqlParameter[1];
            pms[0] = new MySqlParameter("last_name", MySqlDbType.VarChar);
            pms[0].Value = lastName;

            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "get_member_pre_list";

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = pms;

            DataSet ds = new DataSet();

            connection.Open();
            da.Fill(ds);
            return ds;
        }
    }
}

