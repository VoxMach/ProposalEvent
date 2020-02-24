﻿using FireSharp.Config;
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
    public partial class pendingApprover : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "20O72YtkHWmSZDIZ2kF01hmg2T3iSetxJO58CuIu",
            BasePath = "https://event-proposal.firebaseio.com/"
        };
        String fullname;
        String org_type;
        String approver_type;
        String org_name;
        public pendingApprover(String name, String orgtype, String approvertype, String orgname)
        {
            InitializeComponent();
            fullname = name;
            org_type = orgtype;
            approver_type = approvertype;
            org_name = orgname;
         
            
           
            
        }

        private void pendingApprover_Load(object sender, EventArgs e)
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
                FirebaseResponse pen = client.Get("Venue/VenueReservation/");
                Dictionary<string, pending> pending = pen.ResultAs<Dictionary<string, pending>>();
                foreach(var find in pending)
                {
                    string isCompare = find.Value.org_type;
                    string isApprover = find.Value.approver;
                    string isAdviser = find.Value.org_adviser_status;
                    string isPresident = find.Value.org_president_status;
                    string isDean = find.Value.org_dean_status;

                    if (approver_type.Equals("Adviser"))
                    {
                        if (isCompare.Equals(org_type) && isApprover.Equals("Accepted") && isAdviser.Equals("Pending"))
                        {
                            pendinggrid.Rows.Add(find.Value.name_of_project, find.Value.beneficiaries);
                        }
                    }else if (approver_type.Equals("Organization President"))
                    {
                        if (isCompare.Equals(org_type) && isApprover.Equals("Accepted") && isAdviser.Equals("Pending") && isPresident.Equals("Pending"))
                        {
                            pendinggrid.Rows.Add(find.Value.name_of_project, find.Value.beneficiaries);
                        }
                    }
                    else if (approver_type.Equals("Dean's Office"))
                    {
                        if (isCompare.Equals(org_type) && isApprover.Equals("Accepted") && isAdviser.Equals("Pending") && isDean.Equals("Pending"))
                        {
                            pendinggrid.Rows.Add(find.Value.name_of_project, find.Value.beneficiaries);
                        }
                    }


                }
                
                
            }
            catch (Exception)
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            apphome a = new apphome();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}