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
    public partial class SaoRej : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public SaoRej()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            saohome sa = new saohome();
            this.Hide();
            sa.ShowDialog();
            this.Close();
        }

        private void SaoRej_Load(object sender, EventArgs e)
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
            string ids = "Pending";

            FirebaseResponse response = client.Get("SAO/Proposal/");

            Dictionary<string, propose> Dick = response.ResultAs<Dictionary<string, propose>>();
            foreach (var find in Dick)
            {



                if (find.Value.status.Equals("Rejected"))
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
    }
}
