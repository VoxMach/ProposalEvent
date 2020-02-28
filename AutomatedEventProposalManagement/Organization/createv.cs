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
    public partial class createv : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };

        IFirebaseClient client;

        public createv()
        {
            InitializeComponent();
        }
        public static string id;
        public static string oname;
        public static string otype;
        private void createv_Load(object sender, EventArgs e)
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

            id = home.id;
            oname = home.orgname;
            otype = home.orgtype;

            comboBox1.Items.Add("TYK Study Area");
            comboBox1.Items.Add("UE Open Field");
            comboBox1.Items.Add("TYK Lobby");
            comboBox1.Items.Add("Gazebo");
            comboBox1.Items.Add("MMR 3A");
            comboBox1.Items.Add("MMR 3B");
            comboBox1.Items.Add("Computer Laboratories");
            comboBox1.Items.Add("MPH1");
            comboBox1.Items.Add("MPH2");
            comboBox1.Items.Add("MPH3");
            comboBox1.Items.Add("Briefing Room");

            bunifuMaterialTextbox3.Enabled = false;
            bunifuMaterialTextbox4.Enabled = false;

            MessageBox.Show("The collection of data is for the" +
                " purpose of creating event. By signing this form, you are " +
                "certifying that all information provided is true and correct " +
                "and likewise authorizing this office to process of your information." +
                " Your accomplished form will be kept in a secured database management " +
                "and will be disposed after one year.", "Reminder", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (sel1.Equals("TYK Study Area"))
            {
                bunifuMaterialTextbox3.Text = "ESO";
                bunifuMaterialTextbox4.Text = "Chancellor";

            }else if (sel1.Equals("UE Open Field"))
            {
                bunifuMaterialTextbox3.Text = "ESO";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("TYK Lobby"))
            {
                bunifuMaterialTextbox3.Text = "ESO";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("Gazebo"))
            {
                bunifuMaterialTextbox3.Text = "ESO";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("MMR 3A"))
            {
                bunifuMaterialTextbox3.Text = "Information Technology";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("MMR 3B"))
            {
                bunifuMaterialTextbox3.Text = "Information Technology";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("Computer Laboratories"))
            {
                bunifuMaterialTextbox3.Text = "Information Technology";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else if (sel1.Equals("MPH1"))
            {
                bunifuMaterialTextbox3.Text = "Library Head";
                bunifuMaterialTextbox4.Text = "Assistant Director";
            }
            else if (sel1.Equals("MPH2"))
            {
                bunifuMaterialTextbox3.Text = "Library Head";
                bunifuMaterialTextbox4.Text = "Assistant Director";
            }
            else if (sel1.Equals("MPH3"))
            {
                bunifuMaterialTextbox3.Text = "Library Head";
                bunifuMaterialTextbox4.Text = "Chancellor";
            }
            else 
            {
                bunifuMaterialTextbox3.Text = "Eng.";
                bunifuMaterialTextbox4.Text = "Dean's Office";
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string pending = "Pending";
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string timef = dateTimePicker1.Text;
            string timeU = dateTimePicker2.Text;
            string dateev = dateTimePicker3.Text;
            if (string.IsNullOrEmpty(bunifuMaterialTextbox11.Text) ||
                string.IsNullOrEmpty(bunifuMaterialTextbox12.Text) || 
                string.IsNullOrEmpty(bunifuMaterialTextbox9.Text)  ||
                string.IsNullOrEmpty(bunifuMaterialTextbox10.Text) ||
                string.IsNullOrEmpty(bunifuMaterialTextbox8.Text)  || 
                string.IsNullOrEmpty(bunifuMaterialTextbox6.Text)  || 
                string.IsNullOrEmpty(bunifuMaterialTextbox1.Text)  || 
                string.IsNullOrEmpty(bunifuMaterialTextbox2.Text)  || 
                string.IsNullOrEmpty(bunifuMaterialTextbox5.Text)  || 
                string.IsNullOrEmpty(bunifuMaterialTextbox7.Text)) {

                MessageBox.Show("Please Specify All Data.");
            
          
            }
            else if (home.orgtype.Equals("Campus-Wide"))
            {
                VenueReservation vr = new VenueReservation()
                {

                    approver = pending,
                    approver_name = bunifuMaterialTextbox4.Text,
                    beneficiaries = bunifuMaterialTextbox7.Text,
                    committee_in_charge = bunifuMaterialTextbox3.Text,
                    date = today,
                    date_of_event = dateev,
                    description = bunifuMaterialTextbox5.Text,
                    id = id,
                    incharge = pending,
                    name_approver = "Nothing Yet",
                    name_incharge = "Nothing Yet",
                    name_of_project = bunifuMaterialTextbox1.Text,
                    nature_of_project = bunifuMaterialTextbox2.Text,
                    general_objective = bunifuMaterialTextbox6.Text,
                    specific_objective = bunifuMaterialTextbox8.Text,
                    planning_statge = bunifuMaterialTextbox10.Text,
                    implementation = bunifuMaterialTextbox9.Text,
                    resource_req = bunifuMaterialTextbox12.Text,
                    evaluation = bunifuMaterialTextbox11.Text,
                    org_adviser = "Nothing Yet",
                    org_adviser_status = pending,
                    org_name = oname,
                    org_president = "Nothing Yet",
                    org_president_status = pending,
                    org_type = home.orgtype,
                    status = pending,
                    time_from = timef,
                    time_to = timeU,
                    venue = sel1
                };

                var set = client.Push(@"Venue/VenueReservation/", vr);

                MessageBox.Show("Register Success.");

                bunifuMaterialTextbox1.Text = string.Empty;
                bunifuMaterialTextbox2.Text = string.Empty;
                bunifuMaterialTextbox3.Text = string.Empty;
                bunifuMaterialTextbox4.Text = string.Empty;
                bunifuMaterialTextbox5.Text = string.Empty;
                bunifuMaterialTextbox7.Text = string.Empty;
                bunifuMaterialTextbox6.Text = string.Empty;
                bunifuMaterialTextbox8.Text = string.Empty;
                bunifuMaterialTextbox9.Text = string.Empty;
                bunifuMaterialTextbox10.Text = string.Empty;
                bunifuMaterialTextbox11.Text = string.Empty;
                bunifuMaterialTextbox12.Text = string.Empty;

                comboBox1.Text = string.Empty;
            }
            else
            {
                VenueReservation vr = new VenueReservation()
                {

                    approver = pending,
                    approver_name = bunifuMaterialTextbox4.Text,
                    beneficiaries = bunifuMaterialTextbox7.Text,
                    committee_in_charge = bunifuMaterialTextbox3.Text,
                    date = today,
                    date_of_event = dateev,
                    description = bunifuMaterialTextbox5.Text,
                    id = id,
                    incharge = pending,
                    name_approver = "Nothing Yet",
                    name_incharge = "Nothing Yet",
                    name_of_project = bunifuMaterialTextbox1.Text,
                    nature_of_project = bunifuMaterialTextbox2.Text,
                    general_objective = bunifuMaterialTextbox6.Text,
                    specific_objective = bunifuMaterialTextbox8.Text,
                    planning_statge =  bunifuMaterialTextbox10.Text,
                    implementation = bunifuMaterialTextbox9.Text,
                    resource_req = bunifuMaterialTextbox12.Text,
                    evaluation = bunifuMaterialTextbox11.Text,
                    org_adviser = "Nothing Yet",
                    org_adviser_status = pending,
                    org_dean = "Nothing Yet",
                    org_dean_status = pending,
                    org_name = oname,
                    org_president = "Nothing Yet",
                    org_president_status = pending,
                    org_type = home.orgtype,
                    status = pending,
                    time_from = timef,
                    time_to = timeU,
                    venue = sel1
                };

                var set = client.Push(@"Venue/VenueReservation/", vr);

                MessageBox.Show("Register Success.");

                bunifuMaterialTextbox1.Text = string.Empty;
                bunifuMaterialTextbox2.Text = string.Empty;
                bunifuMaterialTextbox3.Text = string.Empty;
                bunifuMaterialTextbox4.Text = string.Empty;
                bunifuMaterialTextbox5.Text = string.Empty;
                bunifuMaterialTextbox7.Text = string.Empty;
                bunifuMaterialTextbox6.Text = string.Empty;
                bunifuMaterialTextbox8.Text = string.Empty;
                bunifuMaterialTextbox9.Text = string.Empty;
                bunifuMaterialTextbox10.Text = string.Empty;
                bunifuMaterialTextbox11.Text = string.Empty;
                bunifuMaterialTextbox12.Text = string.Empty;

                comboBox1.Text = string.Empty;



            }





        }
    }
}
