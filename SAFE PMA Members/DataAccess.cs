using System.Data;
using MySql.Data.MySqlClient;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public List<Member> MemberList(string lastName)
        {
            using var connection = new MySqlConnection (Helper.connVal("members"));
            MySqlCommand cmd = new MySqlCommand();
            connection.Open ();
            cmd.CommandText = "get_user_list";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue ("@last_name", lastName);
            cmd.Parameters["@last_name"].Direction = ParameterDirection.Input;
        }
    }
}
