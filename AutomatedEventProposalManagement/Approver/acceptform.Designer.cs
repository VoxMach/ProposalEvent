namespace AutomatedEventProposalManagement.Approver
{
    partial class acceptform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pendingdate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.venuepending = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.natureofproject = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameofproject = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-11, -112);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 106);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Request";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(644, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 56);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(363, 684);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 68);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reject";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 684);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pendingdate
            // 
            this.pendingdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pendingdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pendingdate.CausesValidation = false;
            this.pendingdate.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pendingdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.pendingdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pendingdate.ForeColor = System.Drawing.Color.Black;
            this.pendingdate.HintForeColor = System.Drawing.Color.Empty;
            this.pendingdate.HintText = "Date of Event";
            this.pendingdate.isPassword = false;
            this.pendingdate.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.pendingdate.LineIdleColor = System.Drawing.Color.Firebrick;
            this.pendingdate.LineMouseHoverColor = System.Drawing.Color.Firebrick;
            this.pendingdate.LineThickness = 3;
            this.pendingdate.Location = new System.Drawing.Point(83, 568);
            this.pendingdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingdate.MaxLength = 32767;
            this.pendingdate.Name = "pendingdate";
            this.pendingdate.Size = new System.Drawing.Size(505, 50);
            this.pendingdate.TabIndex = 14;
            this.pendingdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // venuepending
            // 
            this.venuepending.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.venuepending.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.venuepending.CausesValidation = false;
            this.venuepending.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.venuepending.Cursor = System.Windows.Forms.Cursors.Default;
            this.venuepending.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.venuepending.ForeColor = System.Drawing.Color.Firebrick;
            this.venuepending.HintForeColor = System.Drawing.Color.Empty;
            this.venuepending.HintText = "Venue";
            this.venuepending.isPassword = false;
            this.venuepending.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.venuepending.LineIdleColor = System.Drawing.Color.Firebrick;
            this.venuepending.LineMouseHoverColor = System.Drawing.Color.Firebrick;
            this.venuepending.LineThickness = 3;
            this.venuepending.Location = new System.Drawing.Point(83, 438);
            this.venuepending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.venuepending.MaxLength = 32767;
            this.venuepending.Name = "venuepending";
            this.venuepending.Size = new System.Drawing.Size(505, 50);
            this.venuepending.TabIndex = 13;
            this.venuepending.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // natureofproject
            // 
            this.natureofproject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.natureofproject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.natureofproject.CausesValidation = false;
            this.natureofproject.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.natureofproject.Cursor = System.Windows.Forms.Cursors.Default;
            this.natureofproject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.natureofproject.ForeColor = System.Drawing.Color.Firebrick;
            this.natureofproject.HintForeColor = System.Drawing.Color.Empty;
            this.natureofproject.HintText = "Nature of Project";
            this.natureofproject.isPassword = false;
            this.natureofproject.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.natureofproject.LineIdleColor = System.Drawing.Color.Firebrick;
            this.natureofproject.LineMouseHoverColor = System.Drawing.Color.Firebrick;
            this.natureofproject.LineThickness = 3;
            this.natureofproject.Location = new System.Drawing.Point(83, 308);
            this.natureofproject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.natureofproject.MaxLength = 32767;
            this.natureofproject.Name = "natureofproject";
            this.natureofproject.Size = new System.Drawing.Size(505, 50);
            this.natureofproject.TabIndex = 12;
            this.natureofproject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameofproject
            // 
            this.nameofproject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameofproject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameofproject.CausesValidation = false;
            this.nameofproject.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameofproject.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameofproject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameofproject.ForeColor = System.Drawing.Color.Firebrick;
            this.nameofproject.HintForeColor = System.Drawing.Color.Empty;
            this.nameofproject.HintText = "Name of Project";
            this.nameofproject.isPassword = false;
            this.nameofproject.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.nameofproject.LineIdleColor = System.Drawing.Color.Firebrick;
            this.nameofproject.LineMouseHoverColor = System.Drawing.Color.Firebrick;
            this.nameofproject.LineThickness = 3;
            this.nameofproject.Location = new System.Drawing.Point(83, 176);
            this.nameofproject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameofproject.MaxLength = 32767;
            this.nameofproject.Name = "nameofproject";
            this.nameofproject.Size = new System.Drawing.Size(505, 50);
            this.nameofproject.TabIndex = 11;
            this.nameofproject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 108);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 49);
            this.label2.TabIndex = 11;
            this.label2.Text = "Request";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(645, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 56);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // acceptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 822);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pendingdate);
            this.Controls.Add(this.venuepending);
            this.Controls.Add(this.natureofproject);
            this.Controls.Add(this.nameofproject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(699, 838);
            this.Name = "acceptform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acceptform";
            this.Load += new System.EventHandler(this.acceptform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pendingdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox venuepending;
        private Bunifu.Framework.UI.BunifuMaterialTextbox natureofproject;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameofproject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}