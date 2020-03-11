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
    public partial class saohome : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public saohome()
        {
            InitializeComponent();

            
        }



        private void saohome_Load(object sender, EventArgs e)
        {
                nameu.Text = loginForm.s1;
                label2.Text = loginForm.s2;
                label3.Text = loginForm.s3;
                label4.Text = loginForm.s4;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.CenterToScreen();
            this.WindowState = FormWindowState.Normal;





            connect();
            customnotif();
            grids();

        }
        public void grids()
        {


            this.Invoke((MethodInvoker)delegate {

                string today = DateTime.Now.ToString("yyyy-MM-dd");
                var today1 = DateTime.Now;
                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd";
                var get = time.ToString(format);
                var tomorrow = today1.AddDays(1);

                try
                {
                    FirebaseResponse response = client.Get("SAO/Proposal/");

                    Dictionary<string, propose> Dick = response.ResultAs<Dictionary<string, propose>>();
                    foreach (var find in Dick)
                    {

                        string datnow = find.Value.date_of_event;
                        string pass = DateTime.Now.ToString("yyyy-MM-dd");
                        if (pass.Equals(datnow))
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
                            find.Value.venue
                                );

                        }
                    }
                }
                catch
                {

                }


            });





        }
        public void connect()
        {

            Task task = Task.Factory.StartNew(() => {


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


            });

        }
        public void customnotif()
        {

            this.Invoke((MethodInvoker)delegate {

                try
                {
                    FirebaseResponse response1 = client.Get("SAO/Proposal/");

                    Dictionary<string, propose> Dick1 = response1.ResultAs<Dictionary<string, propose>>();
                    foreach (var pussy in Dick1)
                    {

                        string pens = pussy.Value.status;
                        string namepro = pussy.Value.name_of_project;
                        string prp = pussy.Value.prepared_by;
                        string venue = pussy.Value.venue;
                        string stat = pussy.Value.status;
                        if (pens == "Pending")
                        {
                            this.Alert(namepro, prp, venue, stat, CustomNotif.enmtype.Pending);
                        }

                    }
                }
                catch
                {

                }

            });



            

          
            
        }

        public void Alert(string namep, string prepby, string venue, string status,CustomNotif.enmtype enmtype)
        {
            CustomNotif cus = new CustomNotif();
            cus.shoWAlert(namep,prepby,venue,status,enmtype);
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

        private void button10_Click(object sender, EventArgs e)
        {
            orgalist org = new orgalist();
            org.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            manageacc man = new manageacc();
            this.Hide();
            man.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            orgalist list = new orgalist();
            this.Hide();
            list.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signup si = new signup();
            this.Hide();
            si.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accept acc = new Accept();
            this.Hide();
            acc.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaoPen acc = new SaoPen();
            this.Hide();
            acc.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaoRej acc = new SaoRej();
            this.Hide();
            acc.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {



            acclist acc = new acclist();
            this.Hide();
            acc.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
