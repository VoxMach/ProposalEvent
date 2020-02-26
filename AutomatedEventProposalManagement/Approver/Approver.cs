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
    public partial class approver : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public approver()
        {
            InitializeComponent();
        }

        private void Approver_Load(object sender, EventArgs e)
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
            comboBox1.Items.Add("College of Arts Science");
            comboBox1.Items.Add("College of Business Administration");
            comboBox1.Items.Add("College of Fine Arts, Architecture and Design");
            comboBox1.Items.Add("College of Engeneering");
            comboBox1.Items.Add("Campus-Wide");
            comboBox1.Items.Add("Student Council");

            comboBox3.Items.Add("Dean's Office");
            comboBox3.Items.Add("Organization president");
            comboBox3.Items.Add("Adviser");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup f1 = new signup();
            f1.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string ids;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(bunifuMaterialTextbox1.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox2.Text)
               || string.IsNullOrEmpty(bunifuMaterialTextbox3.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox4.Text)
               || string.IsNullOrEmpty(bunifuMaterialTextbox5.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {

                MessageBox.Show("Please Specify all Blanks.");

            }
            else
            {
                string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                string sel2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                string sel3 = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);
                Appregis c1 = new Appregis()
                {

                    firstname = bunifuMaterialTextbox3.Text,
                    id = bunifuMaterialTextbox1.Text,
                    lastname = bunifuMaterialTextbox5.Text,
                    middlename = bunifuMaterialTextbox4.Text,
                    org_name =  sel2,
                    org_type = sel3,
                    organization_type = sel1,
                    password = bunifuMaterialTextbox2.Text
                };

                var set = client.Set(@"User/Approver/" + bunifuMaterialTextbox1.Text, c1);

                MessageBox.Show("Register Success.");
                bunifuMaterialTextbox1.Text = string.Empty;
                bunifuMaterialTextbox2.Text = string.Empty;
                bunifuMaterialTextbox3.Text = string.Empty;
                bunifuMaterialTextbox4.Text = string.Empty;
                bunifuMaterialTextbox5.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox3.Text = string.Empty;
                comboBox1.Text = string.Empty;

            }
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
            }
            else if (sel1.Equals("College of Fine Arts, Architecture and Design"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Buklod Sining");
                comboBox2.Items.Add("United Architects of the Philipphines Student Auxilliary");
                comboBox2.Items.Add("Society of Interior Design Students(SIDS)");
                comboBox2.Items.Add("Pintura(Probationary)");
                comboBox2.Items.Add("ARK(Probationary)");
            }
            else if (sel1.Equals("College of Engeneering"))
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
            }
            else if (sel1.Equals("Campus-Wide"))
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
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Central Student Council (CSC)");
                comboBox2.Items.Add("(BASC) Business Administration");
                comboBox2.Items.Add("(ESC) Engineering");
                comboBox2.Items.Add("(CASSC) College of Arts");
                comboBox2.Items.Add("(CFAD-SC) College of Fine Arts");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("User/Approver/");
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
