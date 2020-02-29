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


        
        string approvers;
        string fullname;
        string orgtype;
        public acceptform(string key, string date_of_event, string name_of_project, string nature_of_project, string venue, string org_type, string approver_type, string name)
        {
            InitializeComponent();
            ID = key;
            venuepending.Text = venue;
            nameofproject.Text = name_of_project;
            natureofproject.Text = nature_of_project;
            pendingdate.Text = date_of_event;
            orgtype = org_type;
            fullname = name;
            approvers = approver_type;
            
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
                if (orgtype.Equals("Campus-Wide"))
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (approvers.Equals("Adviser"))
            {

                FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                pending pending = response.ResultAs<pending>();



                pending.org_adviser = fullname;
                pending.org_adviser_status = "Rejected";



                FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                MessageBox.Show("Rejected Success");

            }
            else if (approvers.Equals("Organization President"))
            {
                if (orgtype.Equals("Campus-Wide"))
                {
                    FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                    pending pending = response.ResultAs<pending>();


                    pending.org_president = fullname;
                    pending.org_president_status = "Rejected";
                    pending.status = "Rejected";


                    FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                    MessageBox.Show("Rejected Success");
                }
                else
                {
                    FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                    pending pending = response.ResultAs<pending>();



                    pending.org_president = fullname;
                    pending.org_president_status = "Rejected";



                    FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                    MessageBox.Show("Rejected Success");
                }


            }
            else if (approvers.Equals("Dean's Office"))
            {
                FirebaseResponse response = client.Get("Venue/VenueReservation/" + ID);

                pending pending = response.ResultAs<pending>();



                pending.org_dean = fullname;
                pending.status = "Rejected";
                pending.org_dean_status = "Rejected";



                FirebaseResponse res = client.Set("Venue/VenueReservation/" + ID, pending);
                MessageBox.Show("Rejected Success");
            }
        }
    }
}
