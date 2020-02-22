namespace AutomatedEventProposalManagement.admin
{
    partial class settingsForm
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
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.txtRegisterUser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(24, 70);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(218, 45);
            this.btnManageAccount.TabIndex = 0;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // txtRegisterUser
            // 
            this.txtRegisterUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUser.Location = new System.Drawing.Point(24, 121);
            this.txtRegisterUser.Name = "txtRegisterUser";
            this.txtRegisterUser.Size = new System.Drawing.Size(218, 45);
            this.txtRegisterUser.TabIndex = 1;
            this.txtRegisterUser.Text = "Register User";
            this.txtRegisterUser.UseVisualStyleBackColor = true;
            this.txtRegisterUser.Click += new System.EventHandler(this.txtRegisterUser_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Logs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 187);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtRegisterUser);
            this.Controls.Add(this.btnManageAccount);
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button txtRegisterUser;
        private System.Windows.Forms.Button button3;
    }
}