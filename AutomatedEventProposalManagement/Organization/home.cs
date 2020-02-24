using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedEventProposalManagement
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
           
        }

        private void home_Load(object sender, EventArgs e)
        {
            
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;

            nameu.Text = loginForm.s1 +","+loginForm.s5 +" "+loginForm.s6;
            label2.Text = loginForm.s2;
            label3.Text = loginForm.s3;
            label4.Text = loginForm.s4;
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string id;
        public static string orgname;
        public static string orgtype;
        private void button4_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("Are you Sure Want to LagOut?", "",MessageBoxButtons.OKCancel);

            if (select == DialogResult.OK)
            {
                loginForm form = new loginForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

            id = label2.Text;
            orgname = label3.Text;
            orgtype = label4.Text;

            createv c = new createv();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        public static string names;
        public static string typ2;
        private void button5_Click(object sender, EventArgs e)
        {
            myevents me = new myevents();
            names = nameu.Text;
            id = label2.Text;
            typ2 = label4.Text;
            this.Hide();
            me.ShowDialog();
            this.Close();

        }
        public static string idor;
        private void button1_Click(object sender, EventArgs e)
        {
            OAccept oa = new OAccept();
             idor = label2.Text;
            this.Hide();
            oa.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OPend oa = new OPend();
            idor = label2.Text;
            this.Hide();
            oa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORej oa = new ORej();
            idor = label2.Text;
            this.Hide();
            oa.ShowDialog();
            this.Close();
        }
    }
}
