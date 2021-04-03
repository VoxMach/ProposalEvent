using AutomatedEventProposalManagement.Approver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AutomatedEventProposalManagement
{
    public partial class apphome : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public apphome()
        {
            InitializeComponent();
        }

        private void apphome_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;

            Conne();

            nameu.Text = loginForm.s1 + "," + loginForm.s6 + " " + loginForm.s7;
            label2.Text = loginForm.s2;
            label3.Text = loginForm.s3;
            label4.Text = loginForm.s4;
            label5.Text = loginForm.s5;

            this.Invoke((MethodInvoker)delegate {

                string today = DateTime.Now.ToString("yyyy-MM-dd");
                var today1 = DateTime.Now;
                var tomorrow = today1.AddDays(1);



                try
                {
                    FirebaseResponse response = client.Get("SAO/Proposal/");
                    Dictionary<string, propose> Dick = response.ResultAs<Dictionary<string, propose>>();
                    foreach (var find in Dick)
                    {

                        
                        if (DateTime.Now.ToString("yyyy-MM-dd").Equals(find.Value.date_of_event))
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
                            find.Value.planning_statge,
                            find.Value.implementation,
                            find.Value.resource_req,
                            find.Value.evaluation,
                            find.Value.time_from,
                            find.Value.time_to,
                            find.Value.venue,
                             find.Value.venue_inchanger,
                            find.Value.numberAttend
                                    );

                            }
                        }



                    }
                    FirebaseResponse response1 = client.Get("SAO/Proposal/");

                    Dictionary<string, propose> Dick1 = response1.ResultAs<Dictionary<string, propose>>();
                    foreach (var find in Dick1)
                    {

                        string datnow = find.Value.date_of_event;
                        string pass = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                        if (pass.Equals(datnow))
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
                        find.Value.planning_statge,
                        find.Value.implementation,
                        find.Value.resource_req,
                        find.Value.evaluation,
                        find.Value.time_from,
                        find.Value.time_to,
                        find.Value.venue,
                         find.Value.venue_inchanger,
                            find.Value.numberAttend
                                );


                        }
                    }
                }
                catch
                {

                }

            });

            customnotif();




        }
        public void Conne()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {




                }
            }
            catch
            {

            }
        }


        public void customnotif()
        {

            this.Invoke((MethodInvoker)delegate {
                try
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
                        if (type == "Adviser")
                        {

                            if (pens == "Pending" || pens == "Nothing Yet")
                            {
                                this.Alert(namepro, adname, venue, pens, CustomNotif.enmtype.Pending);
                            }

                        }
                        else if (type == "Dean's Office")
                        {
                            if (den2 == "Pending" || den2 == "Nothing Yet")
                            {
                                this.Alert(namepro, den1, venue, den2, CustomNotif.enmtype.Pending);
                            }
                        }
                        else
                        {
                            if (orp1 == "Pending" || orp1 == "Nothing Yet")
                            {
                                this.Alert(namepro, orp, venue, orp1, CustomNotif.enmtype.Pending);
                            }
                        }



                    }
                }
                catch
                {

                }

            });

            
           

        }

        public void Alert(string namep, string prepby, string venue, string status, CustomNotif.enmtype enmtype)
        {
            CustomNotif cus = new CustomNotif();
            cus.shoWAlert(namep, prepby, venue, status,enmtype);
        }
        private void button4_Click(object sender, EventArgs e)
        {

            var select = MessageBox.Show("Are you Sure Want to Log-out?", "", MessageBoxButtons.OKCancel);

            if (select == DialogResult.OK)
            {
                loginForm form = new loginForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pendingApprover a = new pendingApprover(nameu.Text, label5.Text, label4.Text, label3.Text);
            a.ShowDialog();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calendar_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar();
            c.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
