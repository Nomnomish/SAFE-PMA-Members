using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFE_PMA_Members
{
    public partial class viewEditMembers : Form
    {
        List<Member> members = new List<Member>();
        public viewEditMembers()
        {
            InitializeComponent();

            UpdateListing();
        }

        private void UpdateListing()
        {
            membersListbox.DataSource = members;
            membersListbox.DisplayMember = "DisplayInfo";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            members = db.MemberList(LastNameTextbox.Text);

            UpdateListing();
        }

        private void membersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membersListbox.SelectedIndex >= 0)
            {
                int count = membersListbox.SelectedIndex;
                Member selected = members[count];
                editFirstNameTextBox.Text = selected.FirstName;
                editLastNameTextBox.Text = selected.LastName;
                editPhoneNumberTextBox.Text = selected.PhoneNumber;
                editEmailTextBox.Text = selected.Email;
                editReferralIDLabel.Text = selected.ReferralID.ToString();
                editStreetAddressTextBox.Text = selected.StreetAddress;
                editCityTextBox.Text = selected.City;
                editStateTextBox.Text = selected.State;
                editZipCodeTextBox.Text = selected.ZipCode.ToString();
                editCurrentBalanceTextBox.Text = selected.CurrentBalance.ToString();
                editBalanceLabel.Text = selected.LastBalUpdate;
            }
        }

        private void updateMemberButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            if (membersListbox.SelectedIndex >= 0)
            {
                int count = membersListbox.SelectedIndex;
                Member selected = members[count];
                selected.FirstName = editFirstNameTextBox.Text;
                selected.LastName = editLastNameTextBox.Text;
                selected.PhoneNumber = editPhoneNumberTextBox.Text;
                selected.Email = editEmailTextBox.Text;
                selected.StreetAddress = editStreetAddressTextBox.Text;
                selected.City = editCityTextBox.Text;
                selected.State = editStateTextBox.Text;
                selected.ZipCode = Int32.Parse(editZipCodeTextBox.Text);
                if (members[count].CurrentBalance != Int32.Parse(editCurrentBalanceTextBox.Text))
                {
                    selected.CurrentBalance = Int32.Parse(editCurrentBalanceTextBox.Text);
                    DateTime date = DateTime.Now;
                    selected.LastBalUpdate = date.ToLongDateString();
                }
                else
                {
                    selected.CurrentBalance = members[count].CurrentBalance;
                    selected.LastBalUpdate = members[count].LastBalUpdate;
                }
                string Message = "";

                Message = db.MemberUpdate(selected);

                MessageBox.Show(Message);

            }
        }
    }
}
