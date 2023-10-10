using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SAFE_PMA_Members
{
    public partial class addMemberForm : Form
    {
        Member addition = new Member();
        public addMemberForm()
        {
            InitializeComponent();
        }

        private void addSelectMemberButton_Click(object sender, EventArgs e)
        {
            searchMembers form3 = new searchMembers();
            var result = form3.ShowDialog();
            if (result == DialogResult.OK)
            {
                addition.ReferralID = form3.id;
                addSelectMemberLabel.Text = form3.id.ToString();
            }
        }

        private void addSubmitButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Member selected = new Member();

            selected.FirstName = addFirstNameTextBox.Text;
            selected.LastName = addLastNameTextBox.Text;
            selected.PhoneNumber = addPhoneNumberTextBox.Text;
            selected.Email = addEmailTextBox.Text;
            selected.ReferralID = addition.ReferralID;
            selected.StreetAddress = addStreetAddressTextBox.Text;
            selected.City = addCityTextBox.Text;
            selected.State = addStateTextBox.Text;
            selected.ZipCode = Int32.Parse(addZipCodeTextBox.Text);
            selected.CurrentBalance = Int32.Parse(AddCurrentBalanceTextBox.Text);
            DateTime date = DateTime.Now;
            selected.LastBalUpdate = date.ToString("yyyy - MM - dd");


            string Message = "";

            Message = db.MemberInsert(selected);

            MessageBox.Show(Message);
            this.Close();
        }
    }
}
