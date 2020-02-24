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
    public partial class Formtrans : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        IFirebaseClient client;

        public Formtrans()
        {
            InitializeComponent();
        }
        public static string fullname0;
        private void Formtrans_Load(object sender, EventArgs e)
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
            bunifuMaterialTextbox1.Text = venAppen.i1;
            bunifuMaterialTextbox2.Text = venAppen.i2;
            bunifuMaterialTextbox3.Text = venAppen.i3;
            bunifuMaterialTextbox4.Text = venAppen.i4;
            bunifuMaterialTextbox5.Text = venAppen.i5;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            venAppen ven = new venAppen();
            this.Hide();
            ven.ShowDialog();
            this.Close();
        }
        public static string key;
        public static string id;
        private void button1_Click(object sender, EventArgs e)
        {
            fullname0 = venAppen.full1;
            key = venAppen.i0;
            
            FirebaseResponse resp2 = client.Get("Venue/VenueReservation/" + key);

            VenueReservation vr0 = new VenueReservation();
            
            

            VenueReservation vr = new VenueReservation() {

                
            };







        }
    }
}
