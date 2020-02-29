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
    public partial class ProView : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public ProView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            myevents ven = new myevents();
            this.Hide();
            ven.ShowDialog();
            this.Close();

        }

        private void ProView_Load(object sender, EventArgs e)
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

            bunifuMaterialTextbox1.Text = myevents.i12;
            bunifuMaterialTextbox2.Text = myevents.i13;
            bunifuMaterialTextbox3.Text = myevents.i17;
            bunifuMaterialTextbox4.Text = myevents.i19;
            bunifuMaterialTextbox5.Text = myevents.i21;
            
            bunifuMaterialTextbox6.Text = myevents.i0;
            bunifuMaterialTextbox7.Text = myevents.i1;

            bunifuMaterialTextbox1.Enabled = false;
            bunifuMaterialTextbox2.Enabled = false;
            bunifuMaterialTextbox3.Enabled = false;
            bunifuMaterialTextbox4.Enabled = false;
            bunifuMaterialTextbox5.Enabled = false;
            bunifuMaterialTextbox6.Enabled = false;
            bunifuMaterialTextbox7.Enabled = false;
        }
        public static string id00;
        private void button1_Click(object sender, EventArgs e)
        {
            string typ22 = myevents.i24;
            id00 = myevents.i23;
            if (bunifuMaterialTextbox5.Text.Equals("Accepted"))
            {
                propose na = new propose() {
                    beneficiaries = myevents.i8,
                    committee_in_charge = myevents.i2,
                    date = myevents.i4,
                    date_of_event = myevents.i25,
                    description = myevents.i5,
                    id = id00,
                    name_of_project = myevents.i0,
                    nature_of_project = myevents.i1,
                    noted_by_adviser = myevents.i18,
                    noted_by_org_president = myevents.i16,
                    general_objective = myevents.i27,
                    specific_objective = myevents.i28,
                    planning_statge = myevents.i29,
                    implementation = myevents.i30,
                    resource_req = myevents.i31,
                    evaluation = myevents.i32,
                    org_name = myevents.i9,
                    org_type = myevents.i10,
                    prepared_by = myevents.i22,
                    recommending_approval = myevents.i20,
                    status = "Pending",
                    time_from = myevents.i6,
                    time_to = myevents.i7,
                    venue =myevents.i3
                };

                var set = client.Push(@"SAO/Proposal/",na);

                MessageBox.Show("Propose Success.");

            }


        }
    }
}
