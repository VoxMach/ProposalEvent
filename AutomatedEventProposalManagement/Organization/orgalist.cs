using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedEventProposalManagement
{
    public partial class orgalist : Form
    {
        public orgalist()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orgalist_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;

            comboBox1.Items.Add("College of Arts Science");
            comboBox1.Items.Add("College of Business Administration");
            comboBox1.Items.Add("College of Fine Arts, Architecture and Design");
            comboBox1.Items.Add("College of Engeneering");
            comboBox1.Items.Add("Campus-Wide");
            comboBox1.Items.Add("Student Council");

            dataGridView1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (sel1.Equals("College of Arts Science"))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                this.dataGridView1.Rows.Add("1", "Association of Communication Students(ACTIONS)");
                this.dataGridView1.Rows.Add("2", "University of the East Hospitality Management Society(UEHMS)");
                this.dataGridView1.Rows.Add("3", "University of the East Tourism Society(UETS)");
                
               

            }
            else if (sel1.Equals("College of Business Administration"))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
       
                this.dataGridView1.Rows.Add("1", "Association of Tax and Law Students(ATLAS)");
                this.dataGridView1.Rows.Add("2", "Junior Financial Executives(JFINEX)");
                this.dataGridView1.Rows.Add("3", "Junior Philipphine Institute of Accountants(JPIA)");
                this.dataGridView1.Rows.Add("4", "Junior Executive Marketing Society(JEMS) ");
                this.dataGridView1.Rows.Add("5", "Management Association(MAUEK)");
                this.dataGridView1.Rows.Add("6", "Hiyas nang Silangan");
                this.dataGridView1.Rows.Add("7", "BES(Probationary)");
               
            }
            else if (sel1.Equals("College of Fine Arts, Architecture and Design"))
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                this.dataGridView1.Rows.Add("1", "Buklod Sining");
                this.dataGridView1.Rows.Add("2", "United Architects of the Philipphines Student Auxilliary");
                this.dataGridView1.Rows.Add("3", "Society of Interior Design Students(SIDS)");
                this.dataGridView1.Rows.Add("4", "Pintura(Probationary)");
                this.dataGridView1.Rows.Add("5", "ARK(Probationary)");
     

               
            }
            else if (sel1.Equals("College of Engeneering"))
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                this.dataGridView1.Rows.Add("1", "Association of Civil Engineering Students(ACES)");
                this.dataGridView1.Rows.Add("2", "Association of Electrical Engineering Students(AEES)");
                this.dataGridView1.Rows.Add("3", "Association of Computer Studies and System Students");
                this.dataGridView1.Rows.Add("4", "Computer Engineering Students Society(COESS)");
                this.dataGridView1.Rows.Add("5", "Electonics Engineering Society-Institute of Electronics");
                this.dataGridView1.Rows.Add("6", "Institute of Electrical and Electronics Engineers - UE ");
                this.dataGridView1.Rows.Add("7", "League of Information Technology Students(LITS)");
                this.dataGridView1.Rows.Add("8", "Philipphine Society of Mechanical Engineers(PSME)");
               
            }
            else if (sel1.Equals("Campus-Wide"))
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                this.dataGridView1.Rows.Add("1", "CCP");
                this.dataGridView1.Rows.Add("2", "College Y Club");
                this.dataGridView1.Rows.Add("3", "Men in Board(MIB)");
                this.dataGridView1.Rows.Add("4", "Rotaract Club");
                this.dataGridView1.Rows.Add("5", "Lualhati LeagUE of Scholars");
                this.dataGridView1.Rows.Add("6", "Silangan Film Circle");
                this.dataGridView1.Rows.Add("7", "(UE RCYC) Red Cross Council");
                this.dataGridView1.Rows.Add("8", "(UE SONs) Seed of nation");
                this.dataGridView1.Rows.Add("9", "(KKB) Kristiyanong Kabataan");
                this.dataGridView1.Rows.Add("10", "Red Stage Events");
                this.dataGridView1.Rows.Add("11", "(JRQO) Junior Researchers");
                this.dataGridView1.Rows.Add("12", "Debate Society");
                this.dataGridView1.Rows.Add("13", "Artstroke");
                this.dataGridView1.Rows.Add("14", "ARMADA (probationary)");
                this.dataGridView1.Rows.Add("15", "Every Nation Campus (probationary)");

               

            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                this.dataGridView1.Rows.Add("1", "Central Student Council (CSC)");
                this.dataGridView1.Rows.Add("2", "(BASC) Business Administration");
                this.dataGridView1.Rows.Add("3", "(ESC) Engineering");
                this.dataGridView1.Rows.Add("4", "(CASSC) College of Arts");
                this.dataGridView1.Rows.Add("5", "(CFAD-SC) College of Fine Arts");

               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }
    }
}
