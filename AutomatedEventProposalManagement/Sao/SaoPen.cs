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
    public partial class SaoPen : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;
        public SaoPen()
        {
            InitializeComponent();
        }

        private void SaoPen_Load(object sender, EventArgs e)
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


            try
            {
                FirebaseResponse response = client.Get("SAO/Proposal/");

                Dictionary<string, propose> Dick = response.ResultAs<Dictionary<string, propose>>();
                foreach (var find in Dick)
                {



                    if (find.Value.status.Equals("Pending"))
                    {

                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        dataGridView1.Rows.Add(
                    find.Value.beneficiaries,
                        find.Value.committee_in_charge,
                        find.Value.date,
                        find.Value.date_of_event,
                        find.Value.description,
                        find.Value.id,
                        find.Value.name_of_project,
                        find.Value.nature_of_project,
                        find.Value.noted_by_org_president,
                        find.Value.noted_by_adviser,
                        find.Value.org_name,
                        find.Value.org_type,
                        find.Value.prepared_by,
                        find.Value.recommending_approval,
                        find.Value.status,
                        find.Value.general_objective,
                        find.Value.specific_objective,
                        find.Value.planning_stage,
                        find.Value.implementation,
                        find.Value.resource_req,
                        find.Value.evaluation,
                        find.Value.time_from,
                        find.Value.time_to,
                        find.Value.venue,
                        find.Key
                            );

                    }

                }
            }
            catch
            {

            }

            

        }


        private void label4_Click(object sender, EventArgs e)
        {
            saohome sa = new saohome();
            this.Hide();
            sa.ShowDialog();
            this.Close();
        }

        public static string e0;
        public static string e1;
        public static string e2;
        public static string e3;
        public static string e4;
        public static string e5;
        public static string e6;
        public static string e7;
        public static string e8;
        public static string e9;
        public static string e10;
        public static string e11;
        public static string e12;
        public static string e13;
        public static string e14;
        public static string e15;
        public static string e16;
        public static string e17;
        public static string e18;
        public static string e19;
        public static string e20;
        public static string e21;
        public static string e22;
        public static string e23;
        public static string e24;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaoAcccs asaka = new SaoAcccs();
            this.Hide();
            e0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            e1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            e2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            e3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            e4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            e5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            e6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            e7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            e8 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            e9 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            e10 = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            e11 = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            e12 = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            e13 = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            e14 = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            e15 = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            e16 = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            e17 = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            e18 = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            e19 = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            e20 = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            e21 = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            e22 = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            e23 = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            e24 = dataGridView1.CurrentRow.Cells[24].Value.ToString();
            asaka.ShowDialog();
            this.Close();
        }
    }
}
