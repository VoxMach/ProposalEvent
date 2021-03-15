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
    public partial class myevents : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public myevents()
        {


            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        public static string fullan;
        public static string idu;
        private void myevents_Load(object sender, EventArgs e)
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

            fullan = home.names;
            idu = home.id;
            customnotif();
            try
            {
                FirebaseResponse response = client.Get("Venue/VenueReservation/");

                Dictionary<string, VenueReservation> Dick = response.ResultAs<Dictionary<string, VenueReservation>>();
                foreach (var find in Dick)
                {
                    string inc = find.Value.id;

                    if (idu.Equals(inc))
                    {
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        dataGridView1.Rows.Add(
                            find.Value.name_of_project,
                            find.Value.nature_of_project,
                            find.Value.general_objective,
                            find.Value.specific_objective,
                            find.Value.planning_statge,
                            find.Value.implementation,
                            find.Value.resource_req,
                            find.Value.evaluation,
                            find.Value.committee_in_charge,
                            find.Value.venue,
                            find.Value.date,
                            find.Value.description,
                            find.Value.time_from,
                            find.Value.time_to,
                            find.Value.beneficiaries,
                            find.Value.org_name,
                            find.Value.org_type,
                            find.Value.approver_name,
                            find.Value.incharge,
                            find.Value.approver,
                            find.Value.name_incharge,
                            find.Value.name_approver,
                            find.Value.org_president,
                            find.Value.org_president_status,
                            find.Value.org_adviser,
                            find.Value.org_adviser_status,
                            find.Value.org_dean,
                            find.Value.org_dean_status,
                            find.Value.date_of_event,
                            find.Value.status,
                            find.Key
                            );
                    }


                }
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
                MessageBox.Show("No Data to Show.");
            }



        }
        public static string i0;
        public static string i1;
        public static string i2;
        public static string i3;
        public static string i4;
        public static string i5;
        public static string i6;
        public static string i7;
        public static string i8;
        public static string i9;
        public static string i10;
        public static string i11;
        public static string i12;
        public static string i13;
        public static string i14;
        public static string i15;
        public static string i16;
        public static string i17;
        public static string i18;
        public static string i19;
        public static string i20;
        public static string i21;
        public static string i22;
        public static string i23;
        public static string i24;
        public static string i25;
        public static string i26;
        public static string i27;
        public static string i28;
        public static string i29;
        public static string i30;
        public static string i31;
        public static string i32;
        public static string i33;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProView pv = new ProView();
            this.Hide();
            i22 = home.names;
            i23 = home.id;
            i24 = home.typ2;
            i0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            i1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            i27 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            i28 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            i29 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            i30 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            i31 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            i32 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            i2 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            i3 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            i4 = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            i5 = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            i6 = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            i7 = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            i8 = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            i9 = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            i10 = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            i11 = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            i12 = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            i13 = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            i14 = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            i15 = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            i16 = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            i17 = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            i18 = dataGridView1.CurrentRow.Cells[24].Value.ToString();
            i19 = dataGridView1.CurrentRow.Cells[25].Value.ToString();
            i20 = dataGridView1.CurrentRow.Cells[26].Value.ToString();
            i21 = dataGridView1.CurrentRow.Cells[27].Value.ToString();
            i25 = dataGridView1.CurrentRow.Cells[28].Value.ToString();
            i26 = dataGridView1.CurrentRow.Cells[29].Value.ToString();
            i33 = dataGridView1.CurrentRow.Cells[30].Value.ToString();
            pv.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void customnotif()
        {
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

                    string idyou = pussy.Value.id;

                    if (home.id == idyou)
                    {
                        if (pens == "Accepted")
                        {
                            this.Alert(namepro, prp, venue, stat, CustomNotif.enmtype.Accepted);
                        }
                        if (pens == "Rejected")
                        {
                            this.Alert(namepro, prp, venue, stat, CustomNotif.enmtype.Rejected);
                        }
                    }



                }
            }
            catch
            {

            }

            

        }

        public void Alert(string namep, string prepby, string venue, string status, CustomNotif.enmtype enmtype)
        {
            CustomNotif cus = new CustomNotif();
            cus.shoWAlert(namep, prepby, venue, status,enmtype);
        }


    }
}
