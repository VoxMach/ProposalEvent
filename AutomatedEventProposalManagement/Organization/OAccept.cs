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
    public partial class OAccept : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public OAccept()
        {
            InitializeComponent();
        }

        private void OAccept_Load(object sender, EventArgs e)
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
            

            FirebaseResponse response = client.Get("Venue/VenueReservation/");

            Dictionary<string, VenueReservation> Dick = response.ResultAs<Dictionary<string, VenueReservation>>();
            foreach (var find in Dick)
            {


                string ids = find.Value.id;

                if (home.idor.Equals(ids))
                {
                    if (find.Value.status.Equals("Accepted"))
                    {

                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        dataGridView1.Rows.Add(
                         find.Value.approver,
                         find.Value.approver_name,
                         find.Value.beneficiaries,
                         find.Value.committee_in_charge,
                         find.Value.date,
                         find.Value.date_of_event,
                         find.Value.description,
                         find.Value.id,
                         find.Value.incharge,
                         find.Value.name_approver,
                         find.Value.name_incharge,
                         find.Value.name_of_project,
                         find.Value.general_objective,
                         find.Value.specific_objective,
                         find.Value.planning_statge,
                         find.Value.implementation,
                         find.Value.resource_req,
                         find.Value.evaluation,
                         find.Value.nature_of_project,
                         find.Value.org_adviser,
                         find.Value.org_adviser_status,
                          find.Value.org_dean,
                         find.Value.org_dean_status,
                         find.Value.org_name,
                         find.Value.org_president,
                         find.Value.org_president_status,
                         find.Value.org_type,
                         find.Value.status,
                         find.Value.time_from,
                         find.Value.time_to,
                         find.Value.venue
                            );

                    }
                }


               

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
