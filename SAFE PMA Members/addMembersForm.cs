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
            List<ComboItem> list = new List<ComboItem>();
            list.Add(new ComboItem { ID = 0, Text = "Paid" });
            list.Add(new ComboItem { ID = 1, Text = "Unpaid" });
            list.Add(new ComboItem { ID = 2, Text = "Inactive" });
            addMemberStatusComboBox.DataSource = list;
            addMemberStatusComboBox.DisplayMember = "Text";
            addMemberStatusComboBox.ValueMember = "ID";
        }

        private void addSelectMemberButton_Click(object sender, EventArgs e)
        {
            searchMembers form3 = new searchMembers();
            var result = form3.ShowDialog();
            Member referral = new Member();
            DataAccess db = new DataAccess();

            if (result == DialogResult.OK)
            {
                addition.ReferralID = form3.id;
                referral = db.getReferralID(form3.id);
                addSelectMemberLabel.Text = referral.DisplayInfo;
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
            selected.LastBalUpdate = date.ToString("yyyy-MM-dd");
            selected.MembershipID = Int32.Parse(addMembershipIDTextBox.Text);
            selected.MemberStatus = (int)addMemberStatusComboBox.SelectedValue;


            string Message = "";

            Message = db.MemberInsert(selected);

            MessageBox.Show(Message);
            this.Close();
        }
    }
}
