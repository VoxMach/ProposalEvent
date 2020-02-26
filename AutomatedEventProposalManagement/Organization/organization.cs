using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AutomatedEventProposalManagement
{
    public partial class organization : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };

        public organization()
        {
            InitializeComponent();

          
        }
        IFirebaseClient client;
        private void organization_Load(object sender, EventArgs e)
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
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;

            comboBox1.Items.Add("College of Arts Science");
            comboBox1.Items.Add("College of Business Administration");
            comboBox1.Items.Add("College of Fine Arts, Architecture and Design");
            comboBox1.Items.Add("College of Engeneering");
            comboBox1.Items.Add("Campus-Wide");
            comboBox1.Items.Add("Student Council");
           



        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup f1 = new signup();
            f1.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (sel1.Equals("College of Arts Science"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Association of Communication Students(ACTIONS)");
                comboBox2.Items.Add("University of the East Hospitality Management Society(UEHMS)");
                comboBox2.Items.Add("University of the East Tourism Society(UETS)");

            }
            else if (sel1.Equals("College of Business Administration"))
            {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Association of Tax and Law Students(ATLAS)");
                comboBox2.Items.Add("Junior Financial Executives(JFINEX)");
                comboBox2.Items.Add("Junior Philipphine Institute of Accountants(JPIA)");
                comboBox2.Items.Add("Junior Executive Marketing Society(JEMS) ");
                comboBox2.Items.Add("Management Association(MAUEK)");
                comboBox2.Items.Add("Hiyas nang Silangan");
                comboBox2.Items.Add("BES(Probationary)");
            }else if (sel1.Equals("College of Fine Arts, Architecture and Design"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Buklod Sining");
                comboBox2.Items.Add("United Architects of the Philipphines Student Auxilliary");
                comboBox2.Items.Add("Society of Interior Design Students(SIDS)");
                comboBox2.Items.Add("Pintura(Probationary)");
                comboBox2.Items.Add("ARK(Probationary)");
            }else if (sel1.Equals("College of Engeneering"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Association of Civil Engineering Students(ACES)");
                comboBox2.Items.Add("Association of Electrical Engineering Students(AEES)");
                comboBox2.Items.Add("Association of Computer Studies and System Students");
                comboBox2.Items.Add("Computer Engineering Students Society(COESS)");
                comboBox2.Items.Add("Electonics Engineering Society-Institute of Electronics");
                comboBox2.Items.Add("Institute of Electrical and Electronics Engineers - UE ");
                comboBox2.Items.Add("League of Information Technology Students(LITS)");
                comboBox2.Items.Add("Philipphine Society of Mechanical Engineers(PSME)");
            }else if (sel1.Equals("Campus-Wide"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CCP");
                comboBox2.Items.Add("College Y Club");
                comboBox2.Items.Add("Men in Board(MIB)");
                comboBox2.Items.Add("Rotaract Club");
                comboBox2.Items.Add("Lualhati LeagUE of Scholars");
                comboBox2.Items.Add("Silangan Film Circle");
                comboBox2.Items.Add("(UE RCYC) Red Cross Council");
                comboBox2.Items.Add("(UE SONs) Seed of nation");
                comboBox2.Items.Add("(KKB) Kristiyanong Kabataan");
                comboBox2.Items.Add("Red Stage Events");
                comboBox2.Items.Add("(JRQO) Junior Researchers");
                comboBox2.Items.Add("Debate Society");
                comboBox2.Items.Add("Artstroke");
                comboBox2.Items.Add("ARMADA (probationary)");
                comboBox2.Items.Add("Every Nation Campus (probationary)");

            }
            else if(sel1.Equals("Student Council"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Central Student Council (CSC)");
                comboBox2.Items.Add("(BASC) Business Administration");
                comboBox2.Items.Add("(ESC) Engineering");
                comboBox2.Items.Add("(CASSC) College of Arts");
                comboBox2.Items.Add("(CFAD-SC) College of Fine Arts");
            }

        }

        public static string ids;

        private void button1_Click(object sender, EventArgs e)
        {
          
                string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if(string.IsNullOrEmpty(bunifuMaterialTextbox1.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrEmpty(bunifuMaterialTextbox3.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrEmpty(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text)) {

                MessageBox.Show("Please Specify all Blanks.");
            }
           
            else if (sel1.Equals("College of Arts Science"))
                {
                    string cas = "CAS";
                    if (string.IsNullOrEmpty(bunifuMaterialTextbox1.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrEmpty(bunifuMaterialTextbox3.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrEmpty(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {
                    MessageBox.Show("Please Specify all Blanks.");
                }

                    else
                    {
                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = cas,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }

                }
                else if (sel1.Equals("College of Business Administration"))
                {
                    string cba = "CBA";
                    if (string.IsNullOrWhiteSpace(bunifuMaterialTextbox1.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox3.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {

                        MessageBox.Show("Please Specify all blank.");

                    }

                    else
                    {


                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);





                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = cba,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }

                }
                else if (sel1.Equals("College of Fine Arts, Architecture and Design"))
                {
                    string cfad = "CFAD";

                    if (string.IsNullOrWhiteSpace(bunifuMaterialTextbox1.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox3.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {

                        MessageBox.Show("Please Specify all blank.");

                    }

                    else
                    {


                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);





                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = cfad,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }
                }
                else if (sel1.Equals("College of Engeneering"))
                {
                    string coe = "COE";
                    if (string.IsNullOrWhiteSpace(bunifuMaterialTextbox1.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox3.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {

                        MessageBox.Show("Please Specify all blank.");

                    }

                    else
                    {


                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);





                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = coe,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }
                }
                else if (sel1.Equals("Campus-Wide"))
                {
                    string Campus = "Campus-Wide";
                    if (string.IsNullOrWhiteSpace(bunifuMaterialTextbox1.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox3.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {

                        MessageBox.Show("Please Specify all blank.");

                    }

                    else
                    {


                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);





                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = Campus,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }

                }
                else if (sel1.Equals("Student Council"))
                {
                    string sc = "Student Council";
                    if (string.IsNullOrWhiteSpace(bunifuMaterialTextbox1.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox2.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox3.Text) || string.IsNullOrWhiteSpace(bunifuMaterialTextbox4.Text)
                 || string.IsNullOrWhiteSpace(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    {

                        MessageBox.Show("Please Specify all blank.");

                    }

                    else
                    {


                        string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);





                        orgregis c1 = new orgregis()
                        {

                            firstname = bunifuMaterialTextbox3.Text,
                            id = bunifuMaterialTextbox1.Text,
                            lastname = bunifuMaterialTextbox5.Text,
                            middlename = bunifuMaterialTextbox4.Text,
                            org_name = sel2,
                            org_type = sc,
                            password = bunifuMaterialTextbox2.Text
                        };

                        var set = client.Set(@"User/Organization/" + bunifuMaterialTextbox1.Text, c1);

                        MessageBox.Show("Register Success.");
                        bunifuMaterialTextbox1.Text = string.Empty;
                        bunifuMaterialTextbox2.Text = string.Empty;
                        bunifuMaterialTextbox3.Text = string.Empty;
                        bunifuMaterialTextbox4.Text = string.Empty;
                        bunifuMaterialTextbox5.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }
                
            }
           
        

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           


        }
        

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
          

            
           









        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("User/Organization/");
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

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
