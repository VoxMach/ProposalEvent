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
    public partial class VenuePen : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public static string full1;
        public static string otype;

        public VenuePen()
        {
            InitializeComponent();
        }
        
        private void VenuePen_Load(object sender, EventArgs e)
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
        
                string coomit = find.Value.committee_in_charge;
                string inc = find.Value.incharge;

                if (venhome.otap.Equals(coomit))
                {
                    if (inc.Equals(ids))
                    {
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        dataGridView1.Rows.Add(
                            find.Key,
                            find.Value.name_of_project,
                            find.Value.beneficiaries,
                            find.Value.nature_of_project,
                            find.Value.venue,
                            find.Value.date_of_event,
                            find.Value.time_from,
                            find.Value.time_to,
                            find.Value.approver,
                            find.Value.committee_in_charge,
                            find.Value.org_adviser_status,
                            find.Value.org_dean_status,
                            find.Value.org_president_status,
                            find.Value.status);
                    }
                }
                
            }



        }
        public static string i0;
        public static string i1;
        public static string i2;
        public static string i3;
        public static string i4;
        public static string i5;
        public static string i6;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormVen ft = new FormVen();
            this.Hide();
            full1 = venhome.full1;
            otype = venhome.otap;
            i0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            i1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            i2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            i3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            i4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            i5 = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            i6 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ft.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
