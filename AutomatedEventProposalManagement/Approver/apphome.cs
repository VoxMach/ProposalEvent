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
    public partial class apphome : Form
    {
        public apphome()
        {
            InitializeComponent();
        }

        private void apphome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;

            nameu.Text = loginForm.s1;
            label2.Text = loginForm.s2;
            label3.Text = loginForm.s3;
            label4.Text = loginForm.s4;
            label5.Text = loginForm.s5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("Are you Sure Want to LagOut?", "", MessageBoxButtons.OKCancel);

            if (select == DialogResult.OK)
            {
                loginForm form = new loginForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}