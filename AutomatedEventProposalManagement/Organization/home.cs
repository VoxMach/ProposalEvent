using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatedEventProposalManagement.Approver;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AutomatedEventProposalManagement
{
    public partial class home : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public home()
        {
            InitializeComponent();
           
        }

        private void home_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {

                    this.CenterToScreen();
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.WindowState = FormWindowState.Normal;


                }
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }

            nameu.Text = loginForm.s1 +","+loginForm.s5 +" "+loginForm.s6;
            label2.Text = loginForm.s2;
            label3.Text = loginForm.s3;
            label4.Text = loginForm.s4;

            grids();
            customnotif();


        }




        public void grids()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var today1 = DateTime.Now;
            var tomorrow = today1.AddDays(1);

            try
            {
                FirebaseResponse response = client.Get("SAO/Proposal/");

                Dictionary<string, propose> Dick = response.ResultAs<Dictionary<string, propose>>();
                foreach (var find in Dick)
                {

                    string datnow = find.Value.date_of_event;

                    if (today.Equals(datnow))
                    {
                        if (find.Value.status.Equals("Accepted"))
                        {

                            dataGridView1.Update();
                            dataGridView1.Refresh();
                            dataGridView1.Rows.Add(
                        find.Value.beneficiaries,
                        find.Value.committee_in_charge,
                        find.Value.date,
                        find.Value.date_of_event,
                        find.Value.description,
                        find.Value.id,
                        find.Value.name_of_project,
                        find.Value.nature_of_project,
                        find.Value.noted_by_org_president,
                        find.Value.noted_by_adviser,
                        find.Value.org_name,
                        find.Value.org_type,
                        find.Value.prepared_by,
                        find.Value.recommending_approval,
                        find.Value.status,
                        find.Value.general_objective,
                        find.Value.specific_objective,
                        find.Value.planning_stage,
                        find.Value.implementation,
                        find.Value.resource_req,
                        find.Value.evaluation,
                        find.Value.time_from,
                        find.Value.time_to,
                        find.Value.venue
                                );

                        }
                    }



                }
                FirebaseResponse response1 = client.Get("SAO/Proposal/");

                Dictionary<string, propose> Dick1 = response1.ResultAs<Dictionary<string, propose>>();
                foreach (var find in Dick1)
                {

                    string datnow = find.Value.date_of_event;

                    if (tomorrow.Equals(tomorrow))
                    {


                        dataGridView2.Update();
                        dataGridView2.Refresh();
                        dataGridView2.Rows.Add(
                   find.Value.beneficiaries,
                        find.Value.committee_in_charge,
                        find.Value.date,
                        find.Value.date_of_event,
                        find.Value.description,
                        find.Value.id,
                        find.Value.name_of_project,
                        find.Value.nature_of_project,
                        find.Value.noted_by_org_president,
                        find.Value.noted_by_adviser,
                        find.Value.org_name,
                        find.Value.org_type,
                        find.Value.prepared_by,
                        find.Value.recommending_approval,
                        find.Value.status,
                        find.Value.general_objective,
                        find.Value.specific_objective,
                        find.Value.planning_stage,
                        find.Value.implementation,
                        find.Value.resource_req,
                        find.Value.evaluation,
                        find.Value.time_from,
                        find.Value.time_to,
                        find.Value.venue
                            );

                        break;
                    }
                }
            }
            catch
            {

            }

            
        }
        public void customnotif()
        {
            FirebaseResponse response1 = client.Get("Venue/VenueReservation/");

            Dictionary<string, VenueReservation> Dick1 = response1.ResultAs<Dictionary<string, VenueReservation>>();
            foreach (var pussy in Dick1)
            {

                string type = label4.Text;

                string namepro = pussy.Value.name_of_project;
                string prp = pussy.Value.approver_name;
                string venue = pussy.Value.venue;
                string stat = pussy.Value.status;
                string adname = pussy.Value.org_adviser;
                string pens = pussy.Value.org_adviser_status;
                string den1 = pussy.Value.org_dean;
                string den2 = pussy.Value.org_dean_status;
                string orp = pussy.Value.org_president;
                string orp1 = pussy.Value.org_president_status;

                string id = pussy.Value.id;
                string idyous = label2.Text;

                string proname = pussy.Value.approver;
                string provstat = pussy.Value.approver_name;

                string vname = pussy.Value.name_incharge;
                string vstats = pussy.Value.incharge;

                if (idyous == id)
                {
                    if (proname == "Accepted")
                    {
                        this.Alert(namepro, provstat, venue, proname);
                    }
                    if (pens == "Accepted")
                    {
                        this.Alert(namepro, adname, venue, pens);
                    }
                    if (den2 == "Accepted")
                    {
                        this.Alert(namepro, den1, venue, den2);
                    }
                    if (orp1 == "Accepted")
                    {
                        this.Alert(namepro, orp, venue, orp1);
                    }
                    if(vstats == "Accepted")
                    {
                        this.Alert(namepro, vname, venue, vstats);
                    }

                }
            }

        }
        public void Alert(string namep, string prepby, string venue, string status)
        {
            CustomNotif cus = new CustomNotif();
            cus.shoWAlert(namep, prepby, venue, status);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
        public static string id;
        public static string orgname;
        public static string orgtype;
        private void button4_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("Are you Sure Want to Log-out?", "",MessageBoxButtons.OKCancel);

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

        private void button7_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
