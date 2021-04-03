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
    public partial class SaoAcccs : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public SaoAcccs()
        {

            InitializeComponent();
        }

        private void SaoAcccs_Load(object sender, EventArgs e)
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

            bunifuMaterialTextbox1.Enabled = false;
            bunifuMaterialTextbox2.Enabled = false;
            bunifuMaterialTextbox4.Enabled = false;
            bunifuMaterialTextbox5.Enabled = false;


            bunifuMaterialTextbox1.Text = SaoPen.e6;
            bunifuMaterialTextbox2.Text = SaoPen.e7;
            bunifuMaterialTextbox4.Text = SaoPen.e23;
            bunifuMaterialTextbox5.Text = SaoPen.e14;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        public static string vruid;

        public void StatusUpdateReject()
        {
            vruid = SaoPen.e25;
            FirebaseResponse resp = client.Get("Venue/VenueReservation/" + vruid);
            VenueReservation vr = resp.ResultAs<VenueReservation>();
            string status1 = "Rejected";
            VenueReservation nr = new VenueReservation()
            {

                approver = vr.approver,
                approver_name = vr.approver_name,
                beneficiaries = vr.beneficiaries,
                committee_in_charge = vr.committee_in_charge,
                date = vr.date,
                date_of_event = vr.date_of_event,
                description = vr.description,
                id = vr.id,
                incharge = vr.incharge,
                name_approver = vr.name_approver,
                name_incharge = vr.name_incharge,
                name_of_project = vr.name_of_project,
                nature_of_project = vr.nature_of_project,
                general_objective = vr.general_objective,
                specific_objective = vr.specific_objective,
                planning_statge = vr.planning_statge,
                implementation = vr.implementation,
                resource_req = vr.resource_req,
                evaluation = vr.evaluation,
                org_adviser = vr.org_adviser,
                org_adviser_status = vr.org_adviser_status,
                org_dean = vr.org_dean,
                org_dean_status = vr.org_dean_status,
                org_name = vr.org_name,
                org_president = vr.org_president,
                org_president_status = vr.org_president_status,
                org_type = vr.org_type,
                status = status1,
                time_from = vr.time_from,
                time_to = vr.time_to,
                venue = vr.venue,
                readap = vr.readap
            };
            var setmeup = client.Set("Venue/VenueReservation/" + vruid, nr);
        }

        public void StatusupdateAccept()
        {
            vruid = SaoPen.e25;
            FirebaseResponse resp = client.Get("Venue/VenueReservation/" + vruid);
            VenueReservation vr = resp.ResultAs<VenueReservation>();
            string status1 = "Accepted";
            VenueReservation nr = new VenueReservation()
            {

                approver = vr.approver,
                approver_name = vr.approver_name,
                beneficiaries = vr.beneficiaries,
                committee_in_charge = vr.committee_in_charge,
                date = vr.date,
                date_of_event = vr.date_of_event,
                description = vr.description,
                id = vr.id,
                incharge = vr.incharge,
                name_approver = vr.name_approver,
                name_incharge = vr.name_incharge,
                name_of_project = vr.name_of_project,
                nature_of_project = vr.nature_of_project,
                general_objective = vr.general_objective,
                specific_objective = vr.specific_objective,
                planning_statge = vr.planning_statge,
                implementation = vr.implementation,
                resource_req = vr.resource_req,
                evaluation = vr.evaluation,
                org_adviser = vr.org_adviser,
                org_adviser_status = vr.org_adviser_status,
                org_dean = vr.org_dean,
                org_dean_status = vr.org_dean_status,
                org_name = vr.org_name,
                org_president = vr.org_president,
                org_president_status = vr.org_president_status,
                org_type = vr.org_type,
                status = status1,
                time_from = vr.time_from,
                time_to = vr.time_to,
                venue = vr.venue,
                readap = vr.readap
            };
            var setmeup = client.Set("Venue/VenueReservation/" + vruid, nr);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            FirebaseResponse response = client.Get("SAO/Proposal/" + SaoPen.e24); 
            propose get = response.ResultAs<propose>(); 
            string status1 = "Accepted";
            string idsame = get.id;
            string bene = get.beneficiaries;
            string comin = get.committee_in_charge; 
            string dater = get.date;
            string datev = get.date_of_event;
            string des = get.description;
            string eval = get.evaluation;
            string gens = get.general_objective;
            string imp = get.implementation;
            string namp = get.name_of_project;
            string natp = get.nature_of_project;
            string nota = get.noted_by_adviser;
            string notorg = get.noted_by_org_president;
            string org = get.org_name;
            string orgt = get.org_type;
            string plan = get.planning_statge;
            string prep = get.prepared_by;
            string remp = get.recommending_approval;
            string remreq = get.resource_req;
            string spec = get.specific_objective;
            string tim1 = get.time_from;
            string tim2 = get.time_to;
            string vens = get.venue;
            string veni_ic = get.venue_inchanger;
            string numbs = get.numberAttend;

            if (string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
            {
                MessageBox.Show("Please Put a Word Below named Reason.");
            }
            else
            {

                var hehe = new propose()
                {


                    beneficiaries = bene,
                    committee_in_charge = comin,
                    date = dater,
                    date_of_event = datev,
                    description = des,
                    evaluation = eval,
                    general_objective = gens,
                    id = idsame,
                    implementation = imp,
                    name_of_project = namp,
                    nature_of_project = natp,
                    noted_by_adviser = nota,
                    noted_by_org_president = notorg,
                    org_name = org,
                    org_type = orgt,
                    planning_statge = plan,
                    prepared_by = prep,
                    recommending_approval = remp,
                    resource_req = remreq,
                    specific_objective = spec,
                    status = status1,
                    time_from = tim1,
                    time_to = tim2,
                    venue = vens,
                    reason = bunifuMaterialTextbox3.Text,
                    venue_inchanger = veni_ic,
                    numberAttend = numbs
                    
                    
                };

                FirebaseResponse resp = client.Set("SAO/Proposal/" + SaoPen.e24, hehe);
                StatusupdateAccept();
                MessageBox.Show("Accepted Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("SAO/Proposal/" + SaoPen.e24);
            propose get = response.ResultAs<propose>();
            string status1 = "Rejected";
            string idsame = get.id;
            string bene = get.beneficiaries;
            string comin = get.committee_in_charge;
            string dater = get.date;
            string datev = get.date_of_event;
            string des = get.description;
            string eval = get.evaluation;
            string gens = get.general_objective;
            string imp = get.implementation;
            string namp = get.name_of_project;
            string natp = get.nature_of_project;
            string nota = get.noted_by_adviser;
            string notorg = get.noted_by_org_president;
            string org = get.org_name;
            string orgt = get.org_type;
            string plan = get.planning_statge;
            string prep = get.prepared_by;
            string remp = get.recommending_approval;
            string remreq = get.resource_req;
            string spec = get.specific_objective;
            string tim1 = get.time_from;
            string tim2 = get.time_to;
            string vens = get.venue;
            string ven_inc = get.venue_inchanger;
            string numbs = get.numberAttend;
            if (string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
            {
                MessageBox.Show("Please Put a Word Below named Reason.");
            }
            else
            {

                var hehe = new propose()
                {


                    beneficiaries = bene,
                    committee_in_charge = comin,
                    date = dater,
                    date_of_event = datev,
                    description = des,
                    evaluation = eval,
                    general_objective = gens,
                    id = idsame,
                    implementation = imp,
                    name_of_project = namp,
                    nature_of_project = natp,
                    noted_by_adviser = nota,
                    noted_by_org_president = notorg,
                    org_name = org,
                    org_type = orgt,
                    planning_statge = plan,
                    prepared_by = prep,
                    recommending_approval = remp,
                    resource_req = remreq,
                    specific_objective = spec,
                    status = status1,
                    time_from = tim1,
                    time_to = tim2,
                    venue = vens,
                    reason = bunifuMaterialTextbox3.Text,
                    numberAttend = numbs
                };

                FirebaseResponse resp = client.Set("SAO/Proposal/" + SaoPen.e24, hehe);
                StatusUpdateReject();
                MessageBox.Show("Rejected Successfully");

            }
        }
    }
}
