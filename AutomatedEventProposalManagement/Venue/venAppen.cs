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
    public partial class venAppen : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;

        public venAppen()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            VenueApp vrn = new VenueApp();
            this.Hide();
            vrn.ShowDialog();
            this.Close();
        }

        private void venAppen_Load(object sender, EventArgs e)
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
            
            FirebaseResponse response = client.Get("Venue/VenueReservation/");
            Dictionary<string, VenueReservation> Dick = response.ResultAs<Dictionary<string, VenueReservation>>();
            foreach (var find in Dick)
            {
              string ids1 = find.Value.approver;
                if (ids.Equals(ids1))
                {

                    dataGridView1.Rows.Add(find.Value.name_of_project, find.Value.beneficiaries,
                        find.Value.nature_of_project,
                        find.Value.venue, find.Value.date,
                        find.Value.time_from, find.Value.time_to,
                        find.Value.approver,
                        find.Value.committee_in_charge, 
                        find.Value.org_adviser_status,
                        find.Value.org_dean_status,
                        find.Value.org_president_status);

                }
            }


        }
    }
}
