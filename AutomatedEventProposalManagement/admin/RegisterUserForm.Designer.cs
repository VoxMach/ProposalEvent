namespace AutomatedEventProposalManagement.admin
{
    partial class RegisterUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegFullname = new System.Windows.Forms.TextBox();
            this.txtRegIDNum = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtRegPosition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fullname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position/Designation";
            // 
            // txtRegFullname
            // 
            this.txtRegFullname.Location = new System.Drawing.Point(22, 45);
            this.txtRegFullname.Multiline = true;
            this.txtRegFullname.Name = "txtRegFullname";
            this.txtRegFullname.Size = new System.Drawing.Size(262, 30);
            this.txtRegFullname.TabIndex = 5;
            // 
            // txtRegIDNum
            // 
            this.txtRegIDNum.Location = new System.Drawing.Point(22, 109);
            this.txtRegIDNum.Multiline = true;
            this.txtRegIDNum.Name = "txtRegIDNum";
            this.txtRegIDNum.Size = new System.Drawing.Size(262, 30);
            this.txtRegIDNum.TabIndex = 6;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(22, 170);
            this.txtRegPassword.Multiline = true;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(262, 30);
            this.txtRegPassword.TabIndex = 7;
            // 
            // txtRegConfirmPassword
            // 
            this.txtRegConfirmPassword.Location = new System.Drawing.Point(22, 231);
            this.txtRegConfirmPassword.Multiline = true;
            this.txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            this.txtRegConfirmPassword.Size = new System.Drawing.Size(262, 30);
            this.txtRegConfirmPassword.TabIndex = 8;
            // 
            // txtRegPosition
            // 
            this.txtRegPosition.Location = new System.Drawing.Point(22, 293);
            this.txtRegPosition.Multiline = true;
            this.txtRegPosition.Name = "txtRegPosition";
            this.txtRegPosition.Size = new System.Drawing.Size(262, 30);
            this.txtRegPosition.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRegPosition);
            this.Controls.Add(this.txtRegConfirmPassword);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegIDNum);
            this.Controls.Add(this.txtRegFullname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.RegisterUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegFullname;
        private System.Windows.Forms.TextBox txtRegIDNum;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegConfirmPassword;
        private System.Windows.Forms.TextBox txtRegPosition;
        private System.Windows.Forms.Button button1;
    }
}