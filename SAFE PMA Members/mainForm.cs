namespace SAFE_PMA_Members
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void editViewMembersButton_Click(object sender, EventArgs e)
        {
            viewEditMembers form2 = new viewEditMembers();
            form2.ShowDialog();
        }

        private void addMembersButton_Click(object sender, EventArgs e)
        {
            addMemberForm form4 = new addMemberForm();
            form4.ShowDialog();
        }
    }
}