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


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (sel1 == "Approver")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                approver();
            }else if (sel1 == "Organization")
            {

            }
            else
            {

            }
        }

        public void approver()
        {
            FirebaseResponse response = client.Get("Users/Approver");
            Dictionary<string, Appregis> dic = response.ResultAs<Dictionary<string,Appregis>>();
            foreach (var get in dic)
            {

                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Firstname";
                dataGridView1.Columns[2].Name = "Middlename";
                dataGridView1.Columns[3].Name = "Lastname";
                dataGridView1.Columns[4].Name = "Organization Name";
                dataGridView1.Columns[5].Name = "Organization Type";
                dataGridView1.Columns[6].Name = "Organization";
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

    }
}
