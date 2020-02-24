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
    public partial class acceptform : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        String ID;
        String approver;
        String fullname;
        public acceptform(string id, string name_of_project, string nature_of_project, string venue, string date_of_event, string approver_type, string name)
        {
            InitializeComponent();
            ID = id;
            nameofproject.Text = name_of_project;
            natureofproject.Text = nature_of_project;
            venuepending.Text = venue;
            date.Text = date_of_event;
            approver = approver_type;
            fullname = name;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void acceptform_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (approver.Equals("Adviser"))
            {
                accept_delete accept = new accept_delete();
                accept.org_adviser = fullname;
                accept.org_adviser_status = "Accepted";
                FirebaseResponse response = client.Update("Venue/VenueReservation/"+ID,accept);

            }else if (approver.Equals("Organization President"))
            {

            }else if (approver.Equals(" Dean's Office"))
            {

            }
        }
    }
}
