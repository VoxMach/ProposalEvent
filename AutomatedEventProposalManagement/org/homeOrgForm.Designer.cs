namespace AutomatedEventProposalManagement
{
    partial class homeOrg
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeclineEvents = new System.Windows.Forms.Button();
            this.btnPendingRequest = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDeclineEvents);
            this.panel1.Controls.Add(this.btnPendingRequest);
            this.panel1.Location = new System.Drawing.Point(64, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 183);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(455, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeclineEvents
            // 
            this.btnDeclineEvents.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclineEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeclineEvents.Location = new System.Drawing.Point(254, 44);
            this.btnDeclineEvents.Name = "btnDeclineEvents";
            this.btnDeclineEvents.Size = new System.Drawing.Size(162, 95);
            this.btnDeclineEvents.TabIndex = 1;
            this.btnDeclineEvents.Text = "List Of Organization";
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
            this.btnPendingRequest.Text = "Create Proposal";
            this.btnPendingRequest.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(64, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Signout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // homeOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "homeOrg";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeclineEvents;
        private System.Windows.Forms.Button btnPendingRequest;
        private System.Windows.Forms.Button button5;
    }
}