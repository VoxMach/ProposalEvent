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
            this.Hide();
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

            VenueReservation vr0 = resp2.ResultAs<VenueReservation>();

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
            string ins = vr0.incharge;
            string namins = vr0.name_incharge;
            string orga = vr0.org_adviser;
            string orgas = vr0.org_adviser_status;
            string odean = vr0.org_dean;
            string odens = vr0.org_dean_status;
            string orgp = vr0.org_president;
            string orgps = vr0.org_president_status;
            string stats = vr0.status;
            string orgtype = vr0.org_type;
            string gen = vr0.general_objective;
            string spec = vr0.specific_objective;
            string plan = vr0.planning_statge;
            string imp = vr0.implementation;
            string req = vr0.resource_req;
            string eva = vr0.evaluation;
            string ven_in = vr0.venue_incharge;
            string nums = vr0.numberAttend;

            if (ins == "Pending" )
            {
                MessageBox.Show("Wait for the In Charge to in futher.");

            }else if (ins == "Denied" )
            {
                MessageBox.Show("The Following Event is Denied or Rejected Proceed to reject the event.");
            }
            else
            {
                VenueReservation vr = new VenueReservation()
                {


                    approver = app,
                    approver_name = appna,
                    beneficiaries = bene,
                    committee_in_charge = commit,
                    date = dater,
                    date_of_event = dateve,
                    description = Des,
                    id = oid,
                    incharge = ins,
                    name_approver = fullname0,
                    name_incharge = namins,
                    name_of_project = namep,
                    nature_of_project = natp,
                    general_objective = gen,
                    specific_objective = spec,
                    planning_statge = plan,
                    implementation = imp,
                    resource_req = req,
                    evaluation = eva,
                    org_adviser = orga,
                    org_adviser_status = orgas,
                    org_dean = odean,
                    org_dean_status = odens,
                    org_name = orname,
                    org_president = orgp,
                    org_president_status = orgps,
                    org_type = orgtype,
                    status = stats,
                    time_from = time1,
                    time_to = time2,
                    venue = venus,
                    venue_incharge = ven_in,
                    numberAttend = nums

                };


                FirebaseResponse resp = client.Set("Venue/VenueReservation/" + key, vr);
                MessageBox.Show("Update Successfully");

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            fullname0 = venAppen.full1;
            key = venAppen.i0;
            type = venAppen.otype;
            string app = "Rejected";
            FirebaseResponse resp2 = client.Get("Venue/VenueReservation/" + key);

            VenueReservation vr0 = resp2.ResultAs<VenueReservation>();

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
            string ins = vr0.incharge;
            string namins = vr0.name_incharge;
            string orga = vr0.org_adviser;
            string orgas = vr0.org_adviser_status;
            string odean = vr0.org_dean;
            string odens = vr0.org_dean_status;
            string orgp = vr0.org_president;
            string orgps = vr0.org_president_status;
            string stats = vr0.status;
            string ven_in = vr0.venue_incharge;
            string nums = vr0.numberAttend;
            VenueReservation vr = new VenueReservation()
            {

                approver = app,
                approver_name = appna,
                beneficiaries = bene,
                committee_in_charge = commit,
                date = dater,
                date_of_event = dateve,
                description = Des,
                id = oid,
                incharge = ins,
                name_approver = fullname0,
                name_incharge = namins,
                name_of_project = namep,
                nature_of_project = natp,
                org_adviser = orga,
                org_adviser_status = orgas,
                org_dean = odean,
                org_dean_status = odens,
                org_name = orname,
                org_president = orgp,
                org_president_status = orgps,
                org_type = orname,
                status = stats,
                time_from = time1,
                time_to = time2,
                venue = venus,
                venue_incharge = ven_in,
                numberAttend = nums

            };


            FirebaseResponse resp = client.Set("Venue/VenueReservation/" + key, vr);
            MessageBox.Show("The Event is  Rejected Successfully.");

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
