﻿using System;
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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f1 = new loginForm();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            organization org = new organization();
            this.Hide();
            org.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Approver app = new Approver();
            this.Hide();
            app.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            venue ven = new venue();
            this.Hide();
            ven.ShowDialog();
            this.Close();
        }

        private void signup_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
