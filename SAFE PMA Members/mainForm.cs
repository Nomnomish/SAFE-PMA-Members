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
    }
}