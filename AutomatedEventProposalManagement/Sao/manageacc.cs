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
    public partial class manageacc : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public manageacc()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (sel1.Equals("Approver"))
            {
                bunifuMaterialTextbox1.Enabled = true;
            }
            else if (sel1.Equals("Organization"))
            {
                bunifuMaterialTextbox1.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox1.Enabled = true;
            }

        }

        private void manageacc_Load(object sender, EventArgs e)
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
            comboBox1.Items.Add("Approver");
            comboBox1.Items.Add("Organization");
            comboBox1.Items.Add("Venue");
           

            bunifuMaterialTextbox1.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            saohome sa = new saohome();
            this.Hide();
            sa.ShowDialog();
            this.Close();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
           

        }
        public static string ids;
        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {

          string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (sel1.Equals("Approver"))
            {
                bunifuMaterialTextbox1.Enabled = true;

                FirebaseResponse resp = client.Get("User/Approver/" + bunifuMaterialTextbox1.Text);

                Class1 cl = resp.ResultAs<Class1>();

                if (bunifuMaterialTextbox1.Text == cl.id)
                {
                    bunifuMaterialTextbox2.Text = cl.firstname;
                    bunifuMaterialTextbox3.Text = cl.lastname;
                    bunifuMaterialTextbox4.Text = cl.middlename;
                    bunifuMaterialTextbox5.Text = cl.password;

                    MessageBox.Show("Found Exact Data. ");

                }
                else
                {
                    MessageBox.Show("Not Found Data. ");
                }

            }
            else if (sel1.Equals("Organization"))
            {
                bunifuMaterialTextbox1.Enabled = true;

                FirebaseResponse resp = client.Get("User/Organization/" + bunifuMaterialTextbox1.Text);
                orgregis cl = resp.ResultAs<orgregis>();


                if (bunifuMaterialTextbox1.Text == cl.id)
                {
                    bunifuMaterialTextbox2.Text = cl.firstname;
                    bunifuMaterialTextbox3.Text = cl.lastname;
                    bunifuMaterialTextbox4.Text = cl.middlename;
                    bunifuMaterialTextbox5.Text = cl.password;

                    MessageBox.Show("Found Exact Data. ");
                }
                else
                {
                    MessageBox.Show("Not Found Data. ");
                }
            }
            else if(sel1.Equals("Venue"))
            {
                bunifuMaterialTextbox1.Enabled = true;
                FirebaseResponse resp = client.Get("User/Venue/" + bunifuMaterialTextbox1.Text);
                venregis cl = resp.ResultAs<venregis>();

                if (bunifuMaterialTextbox1.Text == cl.id)
                {
                    bunifuMaterialTextbox2.Text = cl.firstname;
                    bunifuMaterialTextbox3.Text = cl.lastname;
                    bunifuMaterialTextbox4.Text = cl.middlename;
                    bunifuMaterialTextbox5.Text = cl.password;

                    MessageBox.Show("Found Exact Data. ");
                }
                else
                {
                    MessageBox.Show("Not Found Data. ");
                }
            }
           
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (sel1.Equals("Approver"))
            {
                bunifuMaterialTextbox1.Enabled = true;
                FirebaseResponse resp1 = client.Get("User/Approver/" + bunifuMaterialTextbox1.Text);

                Class1 cl1 = resp1.ResultAs<Class1>();


                if (bunifuMaterialTextbox1.Text == cl1.id)
                {
                    string get1 = cl1.org_name;
                    string get2 = cl1.org_type;
                    string get3 = cl1.organization_type;
                    Class1 cl = new Class1()
                    {
                        id = bunifuMaterialTextbox1.Text,
                        firstname = bunifuMaterialTextbox2.Text,
                        lastname = bunifuMaterialTextbox3.Text,
                        middlename = bunifuMaterialTextbox4.Text,
                        org_name = get1,
                        org_type =get2,
                        organization_type =get3,
                        password = bunifuMaterialTextbox5.Text
                    };
                    FirebaseResponse resp = client.Set("User/Approver/" + bunifuMaterialTextbox1.Text, cl);
                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
                    

            }
            else if (sel1.Equals("Organization"))
            {
                bunifuMaterialTextbox1.Enabled = true;

                FirebaseResponse resp1 = client.Get("User/Organization/" + bunifuMaterialTextbox1.Text);
                orgregis cl1 = resp1.ResultAs<orgregis>();
                if (bunifuMaterialTextbox1.Text == cl1.id)
                {
                    string get1 = cl1.org_name;
                    string get2 = cl1.org_type;
                    orgregis cl = new orgregis()
                    {
                        id = bunifuMaterialTextbox1.Text,
                        firstname = bunifuMaterialTextbox2.Text,
                        lastname = bunifuMaterialTextbox3.Text,
                        middlename = bunifuMaterialTextbox4.Text,
                        org_name = get1,
                        org_type = get2,
                        password = bunifuMaterialTextbox5.Text
                    };
                    FirebaseResponse resp = client.Set("User/Organization/" + bunifuMaterialTextbox1.Text, cl);
                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    MessageBox.Show("Fail");
                }

            }
            else if (sel1.Equals("Venue"))
            {
                bunifuMaterialTextbox1.Enabled = true;
                FirebaseResponse resp1 = client.Get("User/Venue/" + bunifuMaterialTextbox1.Text);
                venregis cl1 = resp1.ResultAs<venregis>();
                if (bunifuMaterialTextbox1.Text == cl1.id)
                {
                    string get1 = cl1.org_type;

                    venregis cl = new venregis()
                    {
                        id = bunifuMaterialTextbox1.Text,
                        firstname = bunifuMaterialTextbox2.Text,
                        lastname = bunifuMaterialTextbox3.Text,
                        middlename = bunifuMaterialTextbox4.Text,
                        org_type = get1,
                        password = bunifuMaterialTextbox5.Text
                    };
                    FirebaseResponse resp = client.Set("User/Venue/" + bunifuMaterialTextbox1.Text, cl);
                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    MessageBox.Show("Fail");
                }

            }
        }
    }
}
