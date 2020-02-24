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
        public static string full1;
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

                    dataGridView1.Rows.Add(find.Key,find.Value.name_of_project,
                        find.Value.beneficiaries,
                        find.Value.nature_of_project,
                        find.Value.venue,
                        find.Value.date,
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
        public static string i0;
        public static string i1;
        public static string i2;
        public static string i3;
        public static string i4;
        public static string i5;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Formtrans ft = new Formtrans();
            this.Hide();
            full1 = VenueApp.full;
            i0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            i1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            i2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            i3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            i4 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            i5 = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            ft.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
