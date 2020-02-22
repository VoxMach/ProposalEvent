namespace AutomatedEventProposalManagement
{
    partial class homeAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCreateOrganizations = new System.Windows.Forms.Button();
            this.btnRegisteredOrganizations = new System.Windows.Forms.Button();
            this.btnAcceptedProposals = new System.Windows.Forms.Button();
            this.btnDeclineEvents = new System.Windows.Forms.Button();
            this.btnPendingRequest = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnCreateOrganizations);
            this.panel1.Controls.Add(this.btnRegisteredOrganizations);
            this.panel1.Controls.Add(this.btnAcceptedProposals);
            this.panel1.Controls.Add(this.btnDeclineEvents);
            this.panel1.Controls.Add(this.btnPendingRequest);
            this.panel1.Location = new System.Drawing.Point(58, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 322);
            this.panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Location = new System.Drawing.Point(455, 170);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(162, 95);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCreateOrganizations
            // 
            this.btnCreateOrganizations.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrganizations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateOrganizations.Location = new System.Drawing.Point(254, 170);
            this.btnCreateOrganizations.Name = "btnCreateOrganizations";
            this.btnCreateOrganizations.Size = new System.Drawing.Size(162, 95);
            this.btnCreateOrganizations.TabIndex = 4;
            this.btnCreateOrganizations.Text = "Create Organization";
            this.btnCreateOrganizations.UseVisualStyleBackColor = true;
            // 
            // btnRegisteredOrganizations
            // 
            this.btnRegisteredOrganizations.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteredOrganizations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegisteredOrganizations.Location = new System.Drawing.Point(44, 170);
            this.btnRegisteredOrganizations.Name = "btnRegisteredOrganizations";
            this.btnRegisteredOrganizations.Size = new System.Drawing.Size(162, 95);
            this.btnRegisteredOrganizations.TabIndex = 3;
            this.btnRegisteredOrganizations.Text = "Registered Organizations";
            this.btnRegisteredOrganizations.UseVisualStyleBackColor = true;
            // 
            // btnAcceptedProposals
            // 
            this.btnAcceptedProposals.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptedProposals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcceptedProposals.Location = new System.Drawing.Point(455, 44);
            this.btnAcceptedProposals.Name = "btnAcceptedProposals";
            this.btnAcceptedProposals.Size = new System.Drawing.Size(162, 95);
            this.btnAcceptedProposals.TabIndex = 2;
            this.btnAcceptedProposals.Text = "Accepted Proposals";
            this.btnAcceptedProposals.UseVisualStyleBackColor = true;
            // 
            // btnDeclineEvents
            // 
            this.btnDeclineEvents.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclineEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeclineEvents.Location = new System.Drawing.Point(254, 44);
            this.btnDeclineEvents.Name = "btnDeclineEvents";
            this.btnDeclineEvents.Size = new System.Drawing.Size(162, 95);
            this.btnDeclineEvents.TabIndex = 1;
            this.btnDeclineEvents.Text = "Declined Proposals";
            this.btnDeclineEvents.UseVisualStyleBackColor = true;
            // 
            // btnPendingRequest
            // 
            this.btnPendingRequest.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingRequest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPendingRequest.Location = new System.Drawing.Point(44, 44);
            this.btnPendingRequest.Name = "btnPendingRequest";
            this.btnPendingRequest.Size = new System.Drawing.Size(162, 95);
            this.btnPendingRequest.TabIndex = 0;
            this.btnPendingRequest.Text = "Pending Request (12)";
            this.btnPendingRequest.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(58, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Signout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // homeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "homeAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCreateOrganizations;
        private System.Windows.Forms.Button btnRegisteredOrganizations;
        private System.Windows.Forms.Button btnAcceptedProposals;
        private System.Windows.Forms.Button btnDeclineEvents;
        private System.Windows.Forms.Button btnPendingRequest;
        private System.Windows.Forms.Button button5;
    }
}