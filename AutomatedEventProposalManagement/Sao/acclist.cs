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
    public partial class acclist : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public acclist()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            saohome sa = new saohome();
            this.Hide();
            sa.ShowDialog();
            this.Close();
        }

        private void acclist_Load(object sender, EventArgs e)
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
            comboBox1.Items.Add("Venue Approver");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (sel1 == "Approver")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Firstname";
                dataGridView1.Columns[2].HeaderText = "Middlename";
                dataGridView1.Columns[3].HeaderText = "Lastname";
                dataGridView1.Columns[4].HeaderText = "Organization Name";
                dataGridView1.Columns[5].HeaderText = "Organization Type";
                dataGridView1.Columns[6].HeaderText = "Organization";
                approver();
               
            }else if (sel1 == "Organization")
            {
             
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Firstname";
                dataGridView1.Columns[2].HeaderText = "Middlename";
                dataGridView1.Columns[3].HeaderText = "Lastname";
                dataGridView1.Columns[4].HeaderText = "Organization Name";
                dataGridView1.Columns[5].HeaderText = "Organization Type";
                org();
            }
            else if (sel1 == "Venue Approver")
            {

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].HeaderText = "Approver Name";
                dataGridView1.Columns[2].HeaderText = "ID";
                dataGridView1.Columns[2].HeaderText = "Firstname";
                dataGridView1.Columns[3].HeaderText = "Middlename";
                dataGridView1.Columns[4].HeaderText = "Lastname";
                
                VenApp();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Firstname";
                dataGridView1.Columns[2].HeaderText = "Middlename";
                dataGridView1.Columns[3].HeaderText = "Lastname";
                dataGridView1.Columns[4].HeaderText = "Organization Type";
                venue();
            }
        }

        public void venue()
        {
            FirebaseResponse response = client.Get("User/Venue/");
            Dictionary<string, venregis> dic = response.ResultAs<Dictionary<string, venregis>>();
            foreach (var get in dic)
            {

                dataGridView1.Rows.Add(
                    get.Value.id,
                    get.Value.firstname,
                    get.Value.middlename,
                    get.Value.lastname,
                    get.Value.org_type
                    );
            }
        }

        public void VenApp()
        {
            FirebaseResponse response = client.Get("User/VenueApprovers/");
            Dictionary<string, Venappro> dic = response.ResultAs<Dictionary<string, Venappro>>();
            foreach (var get in dic)
            {

                dataGridView1.Rows.Add(
                     get.Value.approver_name,
                    get.Value.id,
                    get.Value.firstname,
                    get.Value.middlename,
                    get.Value.lastname
                   

                    );
            }
        }

        public void approver()
        {
            FirebaseResponse response = client.Get("User/Approver/");
            Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string,Appregis>>();
            foreach (var get in dic)
            {

                dataGridView1.Rows.Add(
                    get.Value.id,
                    get.Value.firstname,
                    get.Value.middlename,
                    get.Value.lastname,
                    get.Value.org_name,
                    get.Value.org_type,
                    get.Value.organization_type
                    );
            }
        }
        public void org()
        {
            FirebaseResponse response = client.Get("User/Organization/");
            Dictionary<string, orgregis> dic = response.ResultAs<Dictionary<string, orgregis>>();
            foreach (var get in dic)
            {

                
                dataGridView1.Rows.Add(
                    get.Value.id,
                    get.Value.firstname,
                    get.Value.middlename,
                    get.Value.lastname,
                    get.Value.org_name,
                    get.Value.org_type
                 
                    );
            }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {

           

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if(string.IsNullOrEmpty(search.Text)){
                MessageBox.Show("Please Enter a Word.");
            }else if (sel1 == "Approver")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname"); dt.Columns.Add("Middlename");
                dt.Columns.Add("Lastname"); dt.Columns.Add("Organization Name");
                dt.Columns.Add("Organization Type"); dt.Columns.Add("Organization");

                FirebaseResponse response = client.Get("User/Approver/");
                Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
                foreach (var get in dic)
                {
                    string ID = get.Value.id;
                    string NAME = get.Value.firstname;
                    string MIDDLE = get.Value.middlename;
                    string LAST = get.Value.lastname;
                    if (search.Text == ID || search.Text == NAME || search.Text == MIDDLE
                        || search.Text == LAST)
                    {
                        dt.Rows.Add(
                        get.Value.id, get.Value.firstname,
                        get.Value.middlename, get.Value.lastname,
                        get.Value.org_name, get.Value.org_type,
                        get.Value.organization_type
                        );
                    }

                    DataView dv = new DataView(dt);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dv;

                }
            }
            else if (sel1 == "Organization")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname"); dt.Columns.Add("Middlename");
                dt.Columns.Add("Lastname"); dt.Columns.Add("Organization Name");
                dt.Columns.Add("Organization Type"); 

                FirebaseResponse response = client.Get("User/Organization/");
                Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
                foreach (var get in dic)
                {
                    string ID = get.Value.id;
                    string NAME = get.Value.firstname;
                    string MIDDLE = get.Value.middlename;
                    string LAST = get.Value.lastname;
                    if (search.Text == ID || search.Text == NAME || search.Text == MIDDLE
                        || search.Text == LAST)
                    {
                        dt.Rows.Add(
                        get.Value.id, get.Value.firstname,
                        get.Value.middlename, get.Value.lastname,
                        get.Value.org_name, get.Value.org_type
                        
                        );
                    }

                    DataView dv = new DataView(dt);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dv;

                }
            }else if (sel1 == "Venue Approver")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Approver Name");
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname"); 
                dt.Columns.Add("Lastname");
                dt.Columns.Add("Middlename");
                

                FirebaseResponse response = client.Get("User/VenueApprovers/");
                Dictionary<string, Venappro> dic = response.ResultAs<Dictionary<string, Venappro>>();
                foreach (var get in dic)
                {
                    string ID = get.Value.id;
                    string NAME = get.Value.firstname;
                    string MIDDLE = get.Value.middlename;
                    string LAST = get.Value.lastname;
                    if (search.Text == ID || search.Text == NAME || search.Text == MIDDLE
                        || search.Text == LAST)
                    {
                        dt.Rows.Add(
                            get.Value.approver_name,
                        get.Value.id, get.Value.firstname,
                        get.Value.middlename, get.Value.lastname
                        );
                    }

                    DataView dv = new DataView(dt);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dv;

                }
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname"); dt.Columns.Add("Middlename");
                dt.Columns.Add("Lastname");
                dt.Columns.Add("Organization Type");

                FirebaseResponse response = client.Get("User/Venue/");
                Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
                foreach (var get in dic)
                {
                    string ID = get.Value.id;
                    string NAME = get.Value.firstname;
                    string MIDDLE = get.Value.middlename;
                    string LAST = get.Value.lastname;
                    if (search.Text == ID || search.Text == NAME || search.Text == MIDDLE
                        || search.Text == LAST)
                    {
                        dt.Rows.Add(
                        get.Value.id, get.Value.firstname,
                        get.Value.middlename, get.Value.lastname,
                        get.Value.org_type

                        );
                    }

                    DataView dv = new DataView(dt);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dv;

                }
            }


               


        }



        //public void searchven()
        //{
        //    dataGridView1.DataSource = null;
        //    dataGridView1.Rows.Clear();
        //    dataGridView1.ColumnCount = 5;
        //    dataGridView1.Columns[0].HeaderText = "ID";
        //    dataGridView1.Columns[1].HeaderText = "Firstname";
        //    dataGridView1.Columns[2].HeaderText = "Middlename";
        //    dataGridView1.Columns[3].HeaderText = "Lastname";
        //    dataGridView1.Columns[4].HeaderText = "Organization Type";

        //    FirebaseResponse response = client.Get("User/Venue/");
        //    Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
        //    foreach (var get in dic)
        //    {

        //        string ids = get.Value.id;

        //        if (bunifuMaterialTextbox1.Text.Equals(ids))
        //        {
        //            dataGridView1.Rows.Add(
        //          get.Value.id,
        //          get.Value.firstname,
        //          get.Value.middlename,
        //          get.Value.lastname,
        //          get.Value.org_type

        //          );


        //        }
        //        else
        //        {
        //            MessageBox.Show("No Data Found.");
        //        }

        //        break;
        //    }


        //}

        //public void searchorg() {

        //    dataGridView1.DataSource = null;
        //    dataGridView1.Rows.Clear();
        //    dataGridView1.ColumnCount = 7;
        //    dataGridView1.Columns[0].HeaderText = "ID";
        //    dataGridView1.Columns[1].HeaderText = "Firstname";
        //    dataGridView1.Columns[2].HeaderText = "Middlename";
        //    dataGridView1.Columns[3].HeaderText = "Lastname";
        //    dataGridView1.Columns[4].HeaderText = "Organization Name";
        //    dataGridView1.Columns[5].HeaderText = "Organization Type";


        //    FirebaseResponse response = client.Get("User/Organization/");
        //    Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
        //    foreach (var get in dic)
        //    {

        //        string ids = get.Value.id;

        //        if (bunifuMaterialTextbox1.Text.Equals(ids))
        //        {
        //            dataGridView1.Rows.Add(
        //          get.Value.id,
        //          get.Value.firstname,
        //          get.Value.middlename,
        //          get.Value.lastname,
        //          get.Value.org_name,
        //          get.Value.org_type

        //          );


        //        }
        //        else
        //        {
        //            MessageBox.Show("No Data Found.");
        //        }
        //        break;

        //    }

        //}
        //public void searchapp()
        //{
        //    dataGridView1.DataSource = null;
        //    dataGridView1.Rows.Clear();
        //    dataGridView1.ColumnCount = 7;
        //    dataGridView1.Columns[0].HeaderText = "ID";
        //    dataGridView1.Columns[1].HeaderText = "Firstname";
        //    dataGridView1.Columns[2].HeaderText = "Middlename";
        //    dataGridView1.Columns[3].HeaderText = "Lastname";
        //    dataGridView1.Columns[4].HeaderText = "Organization Name";
        //    dataGridView1.Columns[5].HeaderText = "Organization Type";
        //    dataGridView1.Columns[6].HeaderText = "Organization";

        //    FirebaseResponse response = client.Get("User/Approver/");
        //    Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string, Appregis>>();
        //    foreach (var get in dic)
        //    {

        //        string ids = get.Value.id;

        //        if (bunifuMaterialTextbox1.Text.Equals(ids))
        //        {
        //            dataGridView1.Rows.Add(
        //          get.Value.id,
        //          get.Value.firstname,
        //          get.Value.middlename,
        //          get.Value.lastname,
        //          get.Value.org_name,
        //          get.Value.org_type,
        //          get.Value.organization_type
        //          );


        //        }
        //        else
        //        {
        //            MessageBox.Show("No Data Found.");
        //        }

        //        break;
        //    }
        //}

    }
}
