namespace Assignment_3
{
    partial class SignPlayer
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.listTeams = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(26, 83);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(229, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Player ID to be signed:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 159);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Team Name:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(262, 83);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 31);
            this.textID.TabIndex = 2;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // listTeams
            // 
            this.listTeams.FormattingEnabled = true;
            this.listTeams.ItemHeight = 25;
            this.listTeams.Location = new System.Drawing.Point(178, 159);
            this.listTeams.Name = "listTeams";
            this.listTeams.Size = new System.Drawing.Size(416, 79);
            this.listTeams.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(178, 311);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(360, 82);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Sign Player";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SignPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listTeams);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "SignPlayer";
            this.Text = "SignPlayer";
            this.Load += new System.EventHandler(this.SignPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.ListBox listTeams;
        private System.Windows.Forms.Button buttonOK;
    }
}