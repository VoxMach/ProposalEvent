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
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
           
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
            FirebaseResponse pen = client.Get("SAO/Proposal/");
            Dictionary<string, pending> pending = pen.ResultAs<Dictionary<string, pending>>();
            foreach (var find in pending)
            {
                string isDate = find.Value.date_of_event;
                if (isDate.Equals("2020-02-24"))
                {
                    calendarDataGrid.Rows.Add(find.Value.date_of_event);
                }

            }
        }

        private void calendarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
