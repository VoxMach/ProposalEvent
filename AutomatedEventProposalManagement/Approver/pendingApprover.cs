using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedEventProposalManagement.Approver
{
    public partial class pendingApprover : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        String fullname;
        String org_type;
        String approver_type;
        String org_name;
        public pendingApprover(String name, String orgtype, String approvertype, String orgname)
        {
            InitializeComponent();
            name = fullname;
            orgtype = org_type;
            approver_type = approvertype;
            org_name = orgname;
            
        }

        private void pendingApprover_Load(object sender, EventArgs e)
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

            try
            {
                FirebaseResponse pen = client.Get(@"Venue/VenueReservation");

                pending pending = pen.ResultAs<pending>();
                MessageBox.Show(pending.approver+" "+ pending.beneficiaries+" "+pending.incharge +" "+pending.name_of_project.ToString());
                
            }
            catch (Exception)
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            apphome a = new apphome();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
