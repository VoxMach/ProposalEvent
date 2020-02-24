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


        String org_type;
        String approvers;
        String fullname;
        public acceptform(string key,
        string approver,
        string approver_name,
        string beneficiaries,
        string committee_in_charge,
        string date,
        string date_of_event,
        string description,
        string id,
        string incharge,
        string name_approver,
        string name_incharge,
        string name_of_project,
        string nature_of_project,
        string org_adviser,
        string org_adviser_status,
        string org_dean,
        string org_dean_status,
        string org_name,
        string org_president,
        string org_president_status,
        string org_type,
        string status,
        string time_from,
        string time_to,
        string venue,
        string approver_type, string name, string organization_type)
        {
            InitializeComponent();
            ID = key;
            nameofproject.Text = name_of_project;
            natureofproject.Text = nature_of_project;
            venuepending.Text = venue;
            pendingdate.Text = date_of_event;
            approvers = approver_type;
            fullname = name;
            org_type = organization_type;
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
            if (approvers.Equals("Adviser"))
            {
                
                FirebaseResponse response = client.Get("Venue/VenueReservation/"+ ID);

                pending pending = response.ResultAs<pending>();


                
                pending.org_adviser = fullname;
                pending.org_adviser_status = "Accepted";
                


                FirebaseResponse res = client.Set("Venue/VenueReservation/"+ID,pending);
              MessageBox.Show("Accept Success");

            }
            else if (approvers.Equals("Organization President"))
            {
                if (org_type.Equals("Campus-Wide"))
                {
                    FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                    pending pending = response.ResultAs<pending>();


                    pending.org_president = fullname;
                    pending.org_president_status = "Accepted";
                    pending.status = "Accepted";


                    FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                    MessageBox.Show("Accept Success");
                }
                else
                {
                    FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                    pending pending = response.ResultAs<pending>();



                    pending.org_president = fullname;
                    pending.org_president_status = "Accepted";



                    FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                    MessageBox.Show("Accept Success");
                }
                

            }
            else if (approvers.Equals("Dean's Office"))
            {
                FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                pending pending = response.ResultAs<pending>();



                pending.org_dean = fullname;
                pending.status = "Accepted";
                pending.org_dean_status = "Accepted";



                FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                MessageBox.Show("Accept Success");
            }



            
        }
    }
}
