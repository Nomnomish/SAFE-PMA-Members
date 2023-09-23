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
            Member output = new Member();
            try
            {
                connection.Open();
                string calling = "get_members";
                MySqlCommand cmd = new MySqlCommand(calling, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@last_name", lastName);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string message = "Reaching out to Database...";
                    MessageBox.Show(message);

                    output.id = rdr.GetInt32("id");
                    output.FirstName = rdr.GetString("firstName");
                    output.LastName = rdr.GetString("lastName");
                    output.PhoneNumber = rdr.GetString("phoneNumber");
                    output.Email = rdr.GetString("email");
                    output.ReferralID = rdr.GetInt32("referralID");
                    output.StreetAddress = rdr.GetString("streetAddress");
                    output.City = rdr.GetString("city");
                    output.State = rdr.GetString("state");
                    output.ZipCode = rdr.GetInt32("zipCode");
                    output.CurrentBalance = rdr.GetInt32("balance");
                    output.LastBalUpdate = rdr.GetMySqlDateTime("lastBalUpdate").ToString();
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            List<Member> op = new List<Member>();
            op.Add(output);
            return op;
            //var output = connection.Query<Member>($"CALL get_members('{lastName}')").ToList();
            //return output;

        }
    }
}

