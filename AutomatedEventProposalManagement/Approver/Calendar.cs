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
    public partial class Calendar : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        public Calendar()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            FirebaseResponse pen = client.Get("SAO/Proposal/");
            Dictionary<string, pending> pending = pen.ResultAs<Dictionary<string, pending>>();
            foreach (var find in pending)
            {
                string isDate = find.Value.date_of_event;
                if (isDate.Equals(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")))
                {

                    calendarDataGrid.Rows.Add( find.Value.beneficiaries, find.Value.committee_in_charge, find.Value.date,
                                find.Value.date_of_event, find.Value.description, find.Value.id,  find.Value.name_of_project,
                                find.Value.nature_of_project, find.Value.noted_by_adviser, find.Value.noted_by_org_president,  find.Value.org_name, find.Value.org_type,
                                find.Value.prepared_by,find.Value.status, find.Value.time_from, find.Value.time_to, find.Value.venue);

                }
               

            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Calendar_Load(object sender, EventArgs e)
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

        private void calendarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
