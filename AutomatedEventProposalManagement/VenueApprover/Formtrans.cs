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
    public partial class Formtrans : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;

        public Formtrans()
        {
            InitializeComponent();
        }
        public static string fullname0;
        private void Formtrans_Load(object sender, EventArgs e)
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
            bunifuMaterialTextbox1.Text = venAppen.i1;
            bunifuMaterialTextbox2.Text = venAppen.i2;
            bunifuMaterialTextbox3.Text = venAppen.i3;
            bunifuMaterialTextbox4.Text = venAppen.i4;
            bunifuMaterialTextbox5.Text = venAppen.i5;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            venAppen ven = new venAppen();
            this.Hide();
            ven.ShowDialog();
            this.Close();
        }
        public static string key;
        public static string id;
        public static string type;
        private void button1_Click(object sender, EventArgs e)
        {
            fullname0 = venAppen.full1;
            key = venAppen.i0;
            type = venAppen.otype;
            string app = "Accepted";
            FirebaseResponse resp2 = client.Get("Venue/VenueReservation/" + key);

            VenueReservation vr0 = new VenueReservation();

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
            VenueReservation vr = new VenueReservation() {

                approver = app,
                approver_name = type,
                beneficiaries = bene,
                committee_in_charge = commit,
                date = dater,
                date_of_event = dateve,
                description = Des,
                id = oid,
                incharge = "Pending",
                name_approver = fullname0,
                name_incharge = "",
                name_of_project = namep,
                nature_of_project = natp,
                org_adviser = "",
                org_adviser_status = "Pending",
                org_dean = "",
                org_dean_status = "Pending",
                org_name = orname,
                org_president = "",
                org_president_status = "Pending",
                org_type = orname,
                status = "Pending",
                time_from = time1,
                time_to = time2,
                venue = venus

            };


            FirebaseResponse resp = client.Set("Venue/VenueReservation/" + key, vr);
            MessageBox.Show("Update Successfully");




        }
    }
}
