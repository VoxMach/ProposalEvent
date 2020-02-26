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
    public partial class venue : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public venue()
        {
            InitializeComponent();
           
        }

        private void venue_Load(object sender, EventArgs e)
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
            comboBox1.Items.Add("ESO");
            comboBox1.Items.Add("Information Technology");
            comboBox1.Items.Add("Library Head");
            comboBox1.Items.Add("Engeenering");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup f1 = new signup();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMaterialTextbox1.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox2.Text)
              || string.IsNullOrEmpty(bunifuMaterialTextbox3.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox4.Text)
              || string.IsNullOrEmpty(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {

                MessageBox.Show("Please Specify all Blanks.");

            }
            else
            {
                string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            
                venregis c1 = new venregis()
                {

                    firstname = bunifuMaterialTextbox3.Text,
                    id = bunifuMaterialTextbox1.Text,
                    lastname = bunifuMaterialTextbox5.Text,
                    middlename = bunifuMaterialTextbox4.Text,
                    org_type = sel1,
                    password = bunifuMaterialTextbox2.Text
                };

                var set = client.Set(@"User/Venue/" + bunifuMaterialTextbox1.Text, c1);

                MessageBox.Show("Register Success.");
                bunifuMaterialTextbox1.Text = string.Empty;
                bunifuMaterialTextbox2.Text = string.Empty;
                bunifuMaterialTextbox3.Text = string.Empty;
                bunifuMaterialTextbox4.Text = string.Empty;
                bunifuMaterialTextbox5.Text = string.Empty;
                comboBox1.Text = string.Empty;
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public static string ids;

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("User/Venue/");
            Dictionary<string, orgregis> Dick = response.ResultAs<Dictionary<string, orgregis>>();
            foreach (var find in Dick)
            {
                ids = find.Value.id;
                if (bunifuMaterialTextbox1.Text.Equals(ids))
                {
                    MessageBox.Show("ID is Already Use");
                    bunifuMaterialTextbox1.Text = string.Empty;
                }

            }
        }
    }
}
