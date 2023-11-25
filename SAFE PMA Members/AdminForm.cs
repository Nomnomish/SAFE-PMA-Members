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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            addAdmin addAdmin = new addAdmin();
            addAdmin.ShowDialog();
        }
    }
}
