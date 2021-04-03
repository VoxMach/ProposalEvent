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

            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

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

            Conn();
            grids();
            grids1();
            customnotif();
            SaoNotif();

        }
        public static string nameproj, venue, userid, status, dateevent,reason;
        private void SaoNotif()
        {
            string get = label2.Text;
            FirebaseResponse response1 = client.Get("SAO/Proposal/");
            Dictionary<string, propose> Dick1 = response1.ResultAs<Dictionary<string, propose>>();
            foreach (var getPussy in Dick1)
            {

                if ( get.Equals(getPussy.Value.id))
                {
                    
                    if (getPussy.Value.status == "Accepted" || getPussy.Value.status == "Rejected") {

                        if (getPussy.Value.readap == "Mark As Read")
                        {


                        } else if (getPussy.Value.readap != "Mark As Read")
                        {
                            
                            MessageBox.Show("Sao Confirm Your Proposal. Click OK for more info.","SAO MESSAGE");
                            nameproj = getPussy.Value.name_of_project;
                            venue = getPussy.Value.venue;
                            userid = getPussy.Key;
                            dateevent = getPussy.Value.date_of_event;
                            status = getPussy.Value.status;
                            reason = getPussy.Value.reason;

                            CheckStatus stats = new CheckStatus();
                            stats.ShowDialog();
                        }

                    }
                }
               

            }



        }
        public void Conn()
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

        public void grids()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var today1 = DateTime.Now;
            DateTime vo = Convert.ToDateTime(today);

            var tomorrow = today1.AddDays(1);

            this.Invoke((MethodInvoker)delegate{
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
                            find.Value.venue,
                            find.Value.venue_inchanger,
                            find.Value.numberAttend
                                    );

                            }
                        }



                    }

                }
                catch
                {

                }
            });


            

            
        }
        public void grids1()
        {

            this.Invoke((MethodInvoker)delegate {

                try
                {
                    FirebaseResponse response1 = client.Get("SAO/Proposal/");

                    Dictionary<string, propose> Dick1 = response1.ResultAs<Dictionary<string, propose>>();
                    foreach (var find in Dick1)
                    {

                        string datnow = find.Value.date_of_event;
                        string pass = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

                        if (datnow.Equals(pass))
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


                
        }
        public void customnotif()
        {

            this.Invoke((MethodInvoker)delegate{


                try
                {
                    FirebaseResponse response1 = client.Get("Venue/VenueReservation/");

                    Dictionary<string, VenueReservation> Dick1 = response1.ResultAs<Dictionary<string, VenueReservation>>();
                    foreach (var pussy in Dick1)
                    {

                        string type = label4.Text;
                        string prp = pussy.Value.approver_name;
                        string stat = pussy.Value.status;
                        
                        if (label2.Text == pussy.Value.id)
                        {

                            if (pussy.Value.readap == "Mark As Read")
                            {



                            }else if (pussy.Value.readap != "Mark As Read")
                            {
                                if (pussy.Value.approver == "Accepted")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.approver_name,
                                        pussy.Value.venue, pussy.Value.approver,CustomNotif.enmtype.Accepted);
                                }
                                else if (pussy.Value.approver == "Rejected")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.approver_name,
                                        pussy.Value.venue, pussy.Value.approver, CustomNotif.enmtype.Rejected);
                                }
                                if (pussy.Value.org_adviser_status == "Accepted")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_adviser,
                                        pussy.Value.venue, pussy.Value.org_adviser_status, CustomNotif.enmtype.Accepted);
                                }
                                else if (pussy.Value.org_adviser_status == "Rejected")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_adviser,
                                        pussy.Value.venue, pussy.Value.org_adviser_status , CustomNotif.enmtype.Rejected);
                                }

                                if (pussy.Value.org_dean_status == "Accepted")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_dean,
                                        pussy.Value.venue, pussy.Value.org_dean_status, CustomNotif.enmtype.Accepted);
                                }
                                else if (pussy.Value.org_dean_status == "Rejected")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_dean,
                                        pussy.Value.venue, pussy.Value.org_dean_status, CustomNotif.enmtype.Rejected);
                                }
                                if (pussy.Value.org_president_status == "Accepted")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_president,
                                        pussy.Value.venue, pussy.Value.org_president_status, CustomNotif.enmtype.Accepted);
                                }
                                else if (pussy.Value.org_president_status == "Rejected")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.org_president,
                                        pussy.Value.venue, pussy.Value.org_president_status, CustomNotif.enmtype.Rejected);
                                }
                                if (pussy.Value.incharge == "Accepted")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.name_incharge,
                                        pussy.Value.venue, pussy.Value.incharge, CustomNotif.enmtype.Accepted);
                                }
                                else if (pussy.Value.incharge == "Rejected")
                                {
                                    this.Alert(pussy.Value.name_of_project, pussy.Value.name_incharge,
                                        pussy.Value.venue, pussy.Value.incharge, CustomNotif.enmtype.Rejected);
                                }
                            }

                            
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
            cus.shoWAlert(namep, prepby, venue, status ,enmtype);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
        public static string id;
        public static string orgname;
        public static string orgtype;
        private void button4_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("Are you Sure Want to Log-out?", "Exit",MessageBoxButtons.OKCancel);

            if (select == DialogResult.OK)
            {
                loginForm form = new loginForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
           
        }

        public void buttonUps()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string curMonth = DateTime.Now.Month.ToString();
            string curYear = DateTime.Now.Year.ToString();
            string curDay = DateTime.Now.Day.ToString();

            string combineAll = curMonth+"-"+curDay+"-"+ curYear;

            string staticDates = "7-23-"+curYear;
            string staticDates1 = "7-24-" + curYear;
            string staticDates2 = "7-25-" + curYear;
            string staticDates3 = "7-26-" + curYear;


            string staticDates4 = "9-5-" + curYear;
            string staticDates5 = "9-6-" + curYear;
            string staticDates6 = "9-7-" + curYear;
            string staticDates7 = "9-8-" + curYear;
            string staticDates8 = "9-9-" + curYear;
            string staticDates9 = "9-10-" + curYear;

            string staticDates10 = "10-21-" + curYear;
            string staticDates11 = "10-22-" + curYear;
            string staticDates12 = "10-23-" + curYear;


            string staticDates13 = "12-16-" + curYear;
            string staticDates14 = "12-17-" + curYear;
            string staticDates15 = "12-18-" + curYear;
            string staticDates16 = "12-19-" + curYear;

            string staticDates17 = "2-10-" + curYear;
            string staticDates18 = "2-11-" + curYear;
            string staticDates19 = "2-12-" + curYear;
            string staticDates20 = "2-13-" + curYear;


            string staticDates21 = "3-26-" + curYear;
            string staticDates22 = "3-27-" + curYear;
            string staticDates23 = "3-28-" + curYear;
            string staticDates24 = "3-29-" + curYear;
            string staticDates25 = "3-30-" + curYear;

            string trialNow = "3-15-" + curYear;
            string trialNow1 = "3-16-" + curYear;

            if (combineAll.Equals(trialNow))
            {
                MessageBox.Show("Can't Create Event Due To upcoming Exams","Alert",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (combineAll.Equals(staticDates) || combineAll.Equals(staticDates1) || combineAll.Equals(staticDates2) ||
                    combineAll.Equals(staticDates3) || combineAll.Equals(staticDates4) || combineAll.Equals(staticDates5) ||
                    combineAll.Equals(staticDates6) || combineAll.Equals(staticDates7) || combineAll.Equals(staticDates8) ||
                    combineAll.Equals(staticDates9) || combineAll.Equals(staticDates10) || combineAll.Equals(staticDates11) ||
                    combineAll.Equals(staticDates12) || combineAll.Equals(staticDates13) || combineAll.Equals(staticDates14) ||
                    combineAll.Equals(staticDates15) || combineAll.Equals(staticDates16) || combineAll.Equals(staticDates17) ||
                    combineAll.Equals(staticDates18) || combineAll.Equals(staticDates19) || combineAll.Equals(staticDates20) ||
                    combineAll.Equals(staticDates21) || combineAll.Equals(staticDates22) || combineAll.Equals(staticDates23) ||
                    combineAll.Equals(staticDates24) || combineAll.Equals(staticDates25))
            {
                MessageBox.Show("Can't Create Event Due To upcoming Exams", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                id = label2.Text;
                orgname = label3.Text;
                orgtype = label4.Text;

                createv c = new createv();
                c.ShowDialog();
            }

            





        }
        public static string names;
        public static string typ2;
        private void button5_Click(object sender, EventArgs e)
        {
            myevents me = new myevents();
            names = nameu.Text;
            id = label2.Text;
            typ2 = label4.Text;
            me.ShowDialog();

        }
        public static string idor;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OAccept oa = new OAccept();
             idor = label2.Text;
            oa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OPend oa = new OPend();
            idor = label2.Text;
            oa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORej oa = new ORej();
            idor = label2.Text;
            oa.ShowDialog();
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
