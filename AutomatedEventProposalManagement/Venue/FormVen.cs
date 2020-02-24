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
    public partial class FormVen : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public FormVen()
        {
            InitializeComponent();
        }

        private void FormVen_Load(object sender, EventArgs e)
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
            bunifuMaterialTextbox1.Text = VenuePen.i1;
            bunifuMaterialTextbox2.Text = VenuePen.i2;
            bunifuMaterialTextbox3.Text = VenuePen.i3;
            bunifuMaterialTextbox4.Text = VenuePen.i4;
            bunifuMaterialTextbox5.Text = VenuePen.i5;

            
            string keys = VenuePen.i0;
            string ven = bunifuMaterialTextbox4.Text;
            string acc = "Accepted";

            FirebaseResponse response = client.Get("Venue/VenueReservation/");

            Dictionary<string, VenueReservation> Dick
                = response.ResultAs<Dictionary<string, VenueReservation>>();

            foreach (var find in Dick)
            {
             
                string name0 = find.Value.name_of_project; 
                string venuss = find.Value.venue;
                string insc = find.Value.incharge;

                if (insc.Equals("Accepted"))
                {
               

                    if (find.Value.date_of_event.Equals(VenuePen.i6))
                    {
                        MessageBox.Show("The Date and Venue is Taken");
                        button1.Enabled = false;
                        break;
                    }

                    break;


                }
                else
                {
                    button1.Enabled = true;
                }

            
               

            }




            }

            private void label4_Click(object sender, EventArgs e)
        {
            VenuePen ven = new VenuePen();
            this.Hide();
            ven.ShowDialog();
            this.Close();
        }

        public static string fullname0;
        public static string key;
        public static string id;
        public static string type;
        public static string datebent;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string app = "Accepted";
            
           FirebaseResponse resp2 = client.Get("Venue/VenueReservation/"+ VenuePen.i0);

            VenueReservation vr0 = resp2.ResultAs<VenueReservation>();

            string appno = vr0.approver;
            string bene = vr0.beneficiaries;
            string commit = vr0.committee_in_charge;
            string dater = vr0.date;
            string dateve = vr0.date_of_event;
            string Des = vr0.description;
            string oid = vr0.id;
            string namep = vr0.name_of_project;
            string natp = vr0.nature_of_project;
            string orname = vr0.org_name;
            string time1 = vr0.time_from;
            string time2 = vr0.time_to;
            string venus = vr0.venue;
            string appna = vr0.approver_name;
            string type = vr0.org_type;
            string nin = vr0.name_incharge;
            string orga = vr0.org_adviser;
            string orgas = vr0.org_adviser_status;
            string odean = vr0.org_dean;
            string odens = vr0.org_dean_status;
            string orgp = vr0.org_president;
            string orgps = vr0.org_president_status;
            string stats = vr0.status;
            string haha = vr0.name_approver;
            VenueReservation vr = new VenueReservation()
            {
                approver = appno,
                approver_name = appna,
                beneficiaries = bene,
                committee_in_charge = commit,
                date = dater,
                date_of_event = dateve,
                description = Des,
                id = oid,
                incharge = app,
                name_approver = haha,
                name_incharge = VenuePen.full1,
                name_of_project = namep,
                nature_of_project = natp,
                org_adviser =orga,
                org_adviser_status =orgas,
                org_dean = odean,
                org_dean_status = odens,
                org_name = orname,
                org_president = orgp,
                org_president_status = orgps,
                org_type = type,
                status = stats,
                time_from = time1,
                time_to = time2,
                venue = venus

            };


            FirebaseResponse resp = client.Set("Venue/VenueReservation/" + VenuePen.i0, vr);
            MessageBox.Show("Update Successfully");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            string app = "Rejected";

            FirebaseResponse resp2 = client.Get("Venue/VenueReservation/" + VenuePen.i0);

            VenueReservation vr0 = resp2.ResultAs<VenueReservation>();

            string appno = vr0.approver;
            string bene = vr0.beneficiaries;
            string commit = vr0.committee_in_charge;
            string dater = vr0.date;
            string dateve = vr0.date_of_event;
            string Des = vr0.description;
            string oid = vr0.id;
            string namep = vr0.name_of_project;
            string natp = vr0.nature_of_project;
            string orname = vr0.org_name;
            string time1 = vr0.time_from;
            string time2 = vr0.time_to;
            string venus = vr0.venue;
            string appna = vr0.approver_name;
            string type = vr0.org_type;
            string nin = vr0.name_incharge;
            string orga = vr0.org_adviser;
            string orgas = vr0.org_adviser_status;
            string odean = vr0.org_dean;
            string odens = vr0.org_dean_status;
            string orgp = vr0.org_president;
            string orgps = vr0.org_president_status;
            string stats = vr0.status;
            string haha = vr0.name_approver;
            VenueReservation vr = new VenueReservation()
            {
                approver = appno,
                approver_name = appna,
                beneficiaries = bene,
                committee_in_charge = commit,
                date = dater,
                date_of_event = dateve,
                description = Des,
                id = oid,
                incharge = app,
                name_approver = haha,
                name_incharge = VenuePen.full1,
                name_of_project = namep,
                nature_of_project = natp,
                org_adviser = orga,
                org_adviser_status = orgas,
                org_dean = odean,
                org_dean_status = odens,
                org_name = orname,
                org_president = orgp,
                org_president_status = orgps,
                org_type = type,
                status = stats,
                time_from = time1,
                time_to = time2,
                venue = venus

            };


            FirebaseResponse resp = client.Set("Venue/VenueReservation/" + VenuePen.i0, vr);
            MessageBox.Show("Update Successfully");

        }
    }
}
