using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFE_PMA_Members
{
    public class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }
    public class Member
    {
        public  int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ReferralID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int CurrentBalance { get; set; }
        public string LastBalUpdate { get; set; }
        public int MemberStatus {  get; set; }
        public int MembershipID {  get; set; }
        public string DisplayInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({Email})";
            }
        }
    }
}
