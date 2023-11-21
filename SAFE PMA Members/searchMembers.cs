using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFE_PMA_Members
{
    public partial class searchMembers : Form
    {
        public int id { get; set; }

        List<Member> members = new List<Member>();
        public searchMembers()
        {
            InitializeComponent();

            UpdateListing();
        }
        private void UpdateListing()
        {
            SearchMemberListBox.DataSource = members;
            SearchMemberListBox.DisplayMember = "DisplayInfo";
        }

        private void SearchMembersSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            members = db.MemberList(SearchLastNameTextBox.Text);

            UpdateListing();
        }

        private void SearchReferralButton_Click(object sender, EventArgs e)
        {
            int count = SearchMemberListBox.SelectedIndex;
            Member selected = members[count];

            this.id = selected.id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SearchLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchMembersSearchButton_Click(sender, e);
            }
        }
    }
}
