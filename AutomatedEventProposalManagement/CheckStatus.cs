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
    public partial class CheckStatus : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public CheckStatus()
        {
            InitializeComponent();
        }

        private void CheckStatus_Load(object sender, EventArgs e)
        {
            Conne();
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;
            bunifuMaterialTextbox1.Text = home.nameproj;
            bunifuMaterialTextbox2.Text = home.dateevent;
            bunifuMaterialTextbox3.Text = home.venue;
            bunifuMaterialTextbox4.Text = home.status;

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

        public void confirmation()
        {
            FirebaseResponse response1 = client.Get("SAO/Proposal/"+home.userid);
            propose prop = response1.ResultAs<propose>();
            propose ose = new propose() { 
            
            beneficiaries = prop.beneficiaries,
            committee_in_charge = prop.committee_in_charge,
            date = prop.date,
            date_of_event = prop.date_of_event,
            description = prop.description,
            evaluation = prop.evaluation,
            general_objective = prop.general_objective,
            id = prop.id,
            implementation = prop.implementation,
            name_of_project = prop.name_of_project,
            nature_of_project = prop.nature_of_project,
            noted_by_adviser = prop.noted_by_adviser,
            noted_by_org_president = prop.noted_by_org_president,
            org_name = prop.org_name,
            org_type = prop.org_type,
            planning_statge = prop.planning_statge,
            prepared_by = prop.prepared_by,
            recommending_approval = prop.recommending_approval,
            resource_req = prop.resource_req,
            specific_objective = prop.specific_objective,
            status = prop.status,
            time_from = prop.time_from,
            time_to  = prop.time_to,
            venue = prop.venue,
            readap = "Mark As Read"
           
            };

            var nicegoing = client.Set("SAO/Proposal/" + home.userid, ose);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            confirmation();
            home h = new home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }
    }
}
