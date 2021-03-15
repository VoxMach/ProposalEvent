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
    public partial class CustomNotif : Form
    {
        public CustomNotif()
        {
            InitializeComponent();
        }

        public enum enAc{

            wait,
            start,
            close

           }
        public enum enmtype
        { 
        
            Rejected,
            Accepted,
            Pending,
            Upcoming,
            Banned

        }

        private CustomNotif.enAc action;
        private int x, y;
        public void shoWAlert(string namep, string prepby, string venue, string status,enmtype type)
        {

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                CustomNotif cus = (CustomNotif)Application.OpenForms[fname];
                
                if (cus == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i -5 * i;
                    this.Location = new Point(this.x,this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case enmtype.Pending:
                    this.label1.Text = namep;
                    this.label2.Text = prepby;
                    this.label3.Text = venue;
                    this.label5.Text = status;
                    this.BackColor = Color.Green;
                    break;
                case enmtype.Accepted:
                    this.label1.Text = namep;
                    this.label2.Text = prepby;
                    this.label3.Text = venue;
                    this.label5.Text = status;
                    this.BackColor = Color.ForestGreen;
                    break;
                case enmtype.Rejected:
                    this.label1.Text = namep;
                    this.label2.Text = prepby;
                    this.label3.Text = venue;
                    this.label5.Text = status;
                    this.BackColor = Color.IndianRed;
                    break;
                case enmtype.Upcoming:
                    this.label1.Text = namep;
                    this.label2.Text = prepby;
                    this.label3.Text = venue;
                    this.label5.Text = status;
                    this.BackColor = Color.Red;
                    break;
                case enmtype.Banned:
                    this.label1.Text = namep;
                    this.label2.Text = prepby;
                    this.label3.Text = venue;
                    this.label5.Text = status;
                    this.BackColor = Color.Blue;
                    break;
            }
            this.Show();
            this.action = enAc.start;
            this.timer1.Interval = 1;
            timer1.Start();

        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enAc.wait:
                    timer1.Interval = 5000;
                    action = enAc.close;

                    break;

                case CustomNotif.enAc.start:

                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                        this.BringToFront();
                   
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enAc.wait;
                        }
                    }

                    break;

                case enAc.close:

                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;

                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                        base.Hide();
                    }

                    break;
                    
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enAc.close;
        }

        private void CustomNotif_Load(object sender, EventArgs e)
        {
       
        }

        private void label00_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enAc.close;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
