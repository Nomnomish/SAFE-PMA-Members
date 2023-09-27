using System.Data;
using MySql.Data.MySqlClient;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public List<Member> MemberList(string lastName)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            List<Member> output = new List<Member>();
            try
            {
                connection.Open();
                string calling = "get_members";
                MySqlCommand cmd = new MySqlCommand(calling, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@last_name", lastName);

                string message = "Reaching out to Database...";
                MessageBox.Show(message);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Member temp = new Member();

                    temp.id = rdr.GetInt32("id");
                    temp.FirstName = rdr.GetString("firstName");
                    temp.LastName = rdr.GetString("lastName");
                    temp.PhoneNumber = rdr.GetString("phoneNumber");
                    temp.Email = rdr.GetString("email");
                    temp.ReferralID = rdr.GetInt32("referralID");
                    temp.StreetAddress = rdr.GetString("streetAddress");
                    temp.City = rdr.GetString("city");
                    temp.State = rdr.GetString("state");
                    temp.ZipCode = rdr.GetInt32("zipCode");
                    temp.CurrentBalance = rdr.GetInt32("balance");
                    temp.LastBalUpdate = rdr.GetMySqlDateTime("lastBalUpdate").ToString();
                    
                    output.Add(temp);
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            
            return output;
        }
    }
}

