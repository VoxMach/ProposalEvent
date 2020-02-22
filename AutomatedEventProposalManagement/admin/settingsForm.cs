using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedEventProposalManagement.admin
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageAccountForm m = new manageAccountForm();
            m.Show();
           
        }

        private void txtRegisterUser_Click(object sender, EventArgs e)
        {
            RegisterUserForm reg = new RegisterUserForm();
            reg.Show();
            this.Hide();
        }
    }
}
