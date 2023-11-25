using System.Data;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public void FileAccess(string[] input)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(folder + "/SAFE")) Directory.CreateDirectory(folder + "/SAFE");
            string fileName = "SAFE-backup.csv";
            string fullPath = folder + "/SAFE/" + fileName;
            File.WriteAllLines(fullPath, input);
        }
         //public string[] BackupAction()
        //{

        //}
        public string[] BackupList()
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            List<Member> output = new List<Member>();
            int count = 0;
            try
            {
                connection.Open();
                string calling = "backup_memberrs";
                MySqlCommand cmd = new MySqlCommand(calling, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                string message = "Backing up Database...";
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
                    temp.JoinedDate = rdr.GetMySqlDateTime("joinedDate").ToString();
                    temp.MembershipLevel = rdr.GetInt32("membershipLevel");

                    output.Add(temp);
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int i = 0;
            string[] values = new string[count];
            foreach (Member temp in output)
            {
                values[i] = temp.id.ToString() + "," + temp.FirstName + "," + temp.LastName + "," + temp.PhoneNumber + "," + temp.Email + "," + temp.ReferralID.ToString() + "," + temp.StreetAddress + "," + temp.City + "," + temp.State + "," + temp.ZipCode.ToString() + "," + temp.CurrentBalance.ToString() + "," + temp.LastBalUpdate + "," + temp.MemberStatus.ToString() + "," + temp.MemberStatus.ToString() + "," + temp.MembershipID.ToString() + "," + temp.JoinedDate + "," + temp.MembershipLevel.ToString();
                i++;
            }
            return values;
        }
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
                    temp.JoinedDate = rdr.GetMySqlDateTime("joinedDate").ToString();
                    temp.MembershipLevel = rdr.GetInt32("membershipLevel");
                    
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
                    temp.JoinedDate = rdr.GetMySqlDateTime("joinedDate").ToString();
                    temp.MembershipLevel = rdr.GetInt32("membershipLevel");

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
            cmd.Parameters.AddWithValue("@p_joinedDate", input.JoinedDate);
            cmd.Parameters["@p_joinedDate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_membershipLevel", input.MembershipLevel);
            cmd.Parameters["@p_membershipLevel"].Direction = ParameterDirection.Input;

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
            cmd.Parameters.AddWithValue("@p_joinedDate", input.JoinedDate);
            cmd.Parameters["@p_joinedDate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@p_membershipLevel", input.MembershipLevel);
            cmd.Parameters["@p_membershipLevel"].Direction = ParameterDirection.Input;

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

        public Member getReferralID(int input)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            string calling = "get_referral_id";

            Member temp = new Member();

            MySqlCommand cmd = new MySqlCommand(calling, connection);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@referral_id", input);
                cmd.Parameters["@referral_id"].Direction = ParameterDirection.Input;
                connection.Open();

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
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
                    temp.JoinedDate = rdr.GetMySqlDateTime("joinedDate").ToString();
                    temp.MembershipLevel = rdr.GetInt32("membershipLevel");
                }
                connection.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return temp;
        }
    }
}

