using System;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
 
namespace AutomatedEventProposalManagement
{

    public partial class loginForm : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };


        public loginForm()
        {
            InitializeComponent();
           

        }
        public static string s1;
        public static string s2;
        public static string s3;
        public static string s4;
        public static string s5;
        public static string s6;
        public static string s7;
        public static string s8;

        private void button1_Click(object sender, System.EventArgs e)
        {
            homeAdminForm h = new homeAdminForm();
            this.Hide();
                
            h.Show();
 
        }

        IFirebaseClient client;

        private void loginForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if(client != null)
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
            comboBox1.Items.Add("Student Affairs Office");
            comboBox1.Items.Add("Venue");
            comboBox1.Items.Add("Venue Approvers");

            textBox1.Enabled = false;
            textBox2.Enabled = false;


           

            

        }

        private void bunifuCustomLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)){

                MessageBox.Show("Please Put Username or Password");

            }else if (sel1.Equals("Approver"))
            {
                try
                {
                    FirebaseResponse resp = client.Get("User/Approver/" + textBox1.Text);

                    Class1 cl = resp.ResultAs<Class1>();

                    if (textBox2.Text == resp.ResultAs<apu>().password)
                    {
                        s1 = cl.firstname;
                        s2 = cl.id;
                        s6 = cl.lastname;
                        s7 = cl.middlename;
                        s3 = cl.org_name;
                        s4 = cl.org_type;
                        s5 = cl.organization_type;

                        apphome ho = new apphome();
                        this.Hide();
                        ho.ShowDialog();
                        this.Close();



                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials");
                        textBox2.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Account Credentials");
                }

            }
            else if (sel1.Equals("Organization"))
            {

                try
                {
                    FirebaseResponse resp = client.Get("User/Organization/" + textBox1.Text);
                    orgregis cl = resp.ResultAs<orgregis>();

                    if (textBox2.Text == resp.ResultAs<apu>().password)
                    {

                        s1 = cl.firstname;
                        s2 = cl.id;
                        s5 = cl.lastname;
                        s6 = cl.middlename;
                        s3 = cl.org_name;
                        s4 = cl.org_type;

                        home h = new home();
                        this.Hide();
                        h.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials");
                        textBox2.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Account Credentials");
                }

            }
            else if (sel1.Equals("Student Affairs Office"))
            {

                try
                {

                    FirebaseResponse resp = client.Get("User/Sao/" + textBox1.Text);
                    saoregis cl = resp.ResultAs<saoregis>();
                    if (textBox2.Text == resp.ResultAs<apu>().password)
                    {

                        s1 = cl.firstname;
                        s2 = cl.id;
                        s3 = cl.lastname;
                        s4 = cl.middlename;
                        saohome hi = new saohome();
                        this.Hide();
                        hi.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Account Credentials");
                }

            }
            else if (sel1.Equals("Venue"))
            {
                try
                {
                    FirebaseResponse resp = client.Get("User/Venue/" + textBox1.Text);
                    venregis cl = resp.ResultAs<venregis>();
                    if (textBox1.Text == resp.ResultAs<apu>().password)
                    {

                        s1 = cl.firstname;
                        s2 = cl.id;
                        s3 = cl.lastname;
                        s4 = cl.middlename;
                        s5 = cl.org_type;

                        venhome h = new venhome();
                        this.Hide();
                        h.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials");
                        textBox2.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Account Credentials");
                }
            }
            else if (sel1.Equals("Venue Approvers"))
            {
                try
                {

                    FirebaseResponse resp = client.Get("User/VenueApprovers/assistantdirector");
                    FirebaseResponse resp1 = client.Get("User/VenueApprovers/chancellor");
                    FirebaseResponse resp2 = client.Get("User/VenueApprovers/deanOffice");

                    VenAppro cl = resp.ResultAs<VenAppro>();
                    VenAppro cl1 = resp1.ResultAs<VenAppro>();
                    VenAppro cl2 = resp2.ResultAs<VenAppro>();
                    if (textBox2.Text == resp.ResultAs<apu>().password)
                    {

                        s1 = cl.firstname;
                        s2 = cl.id;
                        s3 = cl.lastname;
                        s4 = cl.middlename;
                        s5 = cl.approver_name;
                        VenueApp h = new VenueApp();
                        this.Hide();
                        h.ShowDialog();
                        this.Close();
                    } else if (textBox2.Text == resp1.ResultAs<apu>().password)
                    {
                        s1 = cl1.firstname;
                        s2 = cl1.id;
                        s3 = cl1.lastname;
                        s4 = cl1.middlename;
                        s5 = cl1.approver_name;
                        VenueApp h = new VenueApp();
                        this.Hide();
                        h.ShowDialog();
                        this.Close();
                    } else if (textBox2.Text == resp2.ResultAs<apu>().password)
                    {
                        s1 = cl2.firstname;
                        s2 = cl2.id;
                        s3 = cl2.lastname;
                        s4 = cl2.middlename;
                        s5 = cl2.approver_name;
                        VenueApp h = new VenueApp();
                        this.Hide();
                        h.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials");
                        textBox2.Text = string.Empty;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Account Credentials");
                }




            }





        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            signup up = new signup();
            up.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, System.EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, System.EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (sel1.Equals("Approver"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;

            }
            else if (sel1.Equals("Organization"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (sel1.Equals("Student Affairs Office"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (sel1.Equals("Venue"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (sel1.Equals("Venue Approvers"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;

            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
