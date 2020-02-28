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
            SaoPen sap = new SaoPen();
            this.Hide();
            sap.ShowDialog();
            this.Close();
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
            string plan = get.planning_stage;
            string prep = get.prepared_by;
            string remp = get.recommending_approval;
            string remreq = get.resource_req;
            string spec = get.specific_objective;
            string tim1 = get.time_from;
            string tim2 = get.time_to;
            string vens = get.venue;

            var hehe = new propose() { 
            

                beneficiaries = bene ,
                committee_in_charge = comin ,
                date= dater,
                date_of_event = datev,
                description = des,
                evaluation = eval ,
                general_objective = gens, 
                id = idsame,
                implementation = imp,
                name_of_project = namp,
                nature_of_project = natp,
                noted_by_adviser = nota,
                noted_by_org_president = notorg,
                org_name = org,
                org_type = orgt,
                planning_stage = plan,
                prepared_by = prep,
                recommending_approval = remp,
                resource_req = remreq,
                specific_objective = spec,
                status = status1 ,    
                time_from = tim1,
                time_to = tim2,
                venue= vens
            };

            FirebaseResponse resp = client.Set("SAO/Proposal/" + SaoPen.e24,hehe);
            MessageBox.Show("Accepted Successfully");

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
            string plan = get.planning_stage;
            string prep = get.prepared_by;
            string remp = get.recommending_approval;
            string remreq = get.resource_req;
            string spec = get.specific_objective;
            string tim1 = get.time_from;
            string tim2 = get.time_to;
            string vens = get.venue;

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
                planning_stage = plan,
                prepared_by = prep,
                recommending_approval = remp,
                resource_req = remreq,
                specific_objective = spec,
                status = status1,
                time_from = tim1,
                time_to = tim2,
                venue = vens
            };

            FirebaseResponse resp = client.Set("SAO/Proposal/" + SaoPen.e24, hehe);
            MessageBox.Show("Accepted Successfully");
        }
    }
}
