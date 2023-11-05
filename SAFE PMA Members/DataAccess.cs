using System.Data;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
                    temp.MembershipID = rdr.GetInt32("membershipID");
                    temp.MemberStatus = rdr.GetInt32("memberStatus");
                    
                    output.Add(temp);
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            
            return output;
        }

        public List<Member> ReferralUpdate(Member input)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            string calling = "get_referrals";
            List<Member> output = new List<Member>();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(calling, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@referral_id", input.id);
                cmd.Parameters["@referral_id"].Direction = ParameterDirection.Input;

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
                    temp.MembershipID = rdr.GetInt32("membershipID");
                    temp.MemberStatus = rdr.GetInt32("memberStatus");

                    output.Add(temp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        connection.Close();
            
            return output;
        }

        public string MemberUpdate(Member input)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            string calling = "updates_members";
            string Msg = "";

            MySqlCommand cmd = new MySqlCommand(calling, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", input.id);
            cmd.Parameters["@p_id"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_firstName", input.FirstName);
            cmd.Parameters["@p_firstName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_lastName", input.LastName);
            cmd.Parameters["@p_lastName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_phoneNumber", input.PhoneNumber);
            cmd.Parameters["@p_phoneNumber"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_email", input.Email);
            cmd.Parameters["@p_email"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_streetAddress", input.StreetAddress);
            cmd.Parameters["@p_streetAddress"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_city", input.City);
            cmd.Parameters["@p_city"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_state", input.State);
            cmd.Parameters["@p_state"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_zipCode", input.ZipCode);
            cmd.Parameters["@p_zipCode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_balance", input.CurrentBalance);
            cmd.Parameters["@p_balance"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_LastBalUpdate", input.LastBalUpdate);
            cmd.Parameters["@p_LastBalUpdate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_membershipID", input.MembershipID);
            cmd.Parameters["@p_membershipID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_memberStatus", input.MemberStatus);
            cmd.Parameters["@p_memberStatus"].Direction = ParameterDirection.Input;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Msg = "Successfully updated.";
            }
            catch 
            {
                Msg = "Error while updating";
            }

            return Msg;
        }

        public string MemberInsert(Member input)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            string calling = "inserts_member";
            string Msg = "";

            MySqlCommand cmd = new MySqlCommand(calling, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_firstName", input.FirstName);
            cmd.Parameters["@p_firstName"].Direction= ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_lastName", input.LastName);
            cmd.Parameters["@p_lastName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_phoneNumber", input.PhoneNumber);
            cmd.Parameters["@p_phoneNumber"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_email", input.Email);
            cmd.Parameters["@p_email"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_referralID", input.ReferralID);
            cmd.Parameters["@p_referralID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_streetAddress", input.StreetAddress);
            cmd.Parameters["@p_streetAddress"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_city", input.City);
            cmd.Parameters["@p_city"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_state", input.State);
            cmd.Parameters["@p_state"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_zipCode", input.ZipCode);
            cmd.Parameters["@p_zipCode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_balance", input.CurrentBalance);
            cmd.Parameters["@p_balance"].Direction = ParameterDirection.Input;            
            cmd.Parameters.AddWithValue("@p_lastBalUpdate", input.LastBalUpdate);
            cmd.Parameters["@p_lastBalUpdate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_membershipID", input.MembershipID);
            cmd.Parameters["@p_membershipID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_memberStatus", input.MemberStatus);
            cmd.Parameters["@p_memberStatus"].Direction = ParameterDirection.Input;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Msg = "Successfully updated.";
            }
            catch
            {
                Msg = "Error while updating";
            }

            return Msg;
        }
    }
}

