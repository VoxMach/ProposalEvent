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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AutomatedEventProposalManagement.admin
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };

        IFirebaseClient client;



        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                fullName = txtRegFullname.Text,
                IDNumber = txtRegIDNum.Text,
                userPass = txtRegPassword.Text,
                position = txtRegPosition.Text
            };

            SetResponse response = await client.SetTaskAsync("User/" + txtRegIDNum.Text, data);
            Data result = response.ResultAs<Data>();
            

            MessageBox.Show("Data Inserted " + result.IDNumber);
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    MessageBox.Show("Connection Established");
                }
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }
    }
}
