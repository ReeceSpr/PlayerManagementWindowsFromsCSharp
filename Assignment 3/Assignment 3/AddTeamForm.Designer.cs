namespace Assignment_3
{
    partial class AddTeamForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelGround = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textGround = new System.Windows.Forms.TextBox();
            this.textCoach = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Team Name:";
            // 
            // labelGround
            // 
            this.labelGround.AutoSize = true;
            this.labelGround.Location = new System.Drawing.Point(26, 90);
            this.labelGround.Name = "labelGround";
            this.labelGround.Size = new System.Drawing.Size(162, 25);
            this.labelGround.TabIndex = 1;
            this.labelGround.Text = "Home Grounds:";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(26, 150);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(137, 25);
            this.labelCoach.TabIndex = 2;
            this.labelCoach.Text = "Head Coach:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(26, 213);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(155, 25);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Founded Year:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(26, 269);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(191, 25);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Founded Location:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(224, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(475, 31);
            this.textName.TabIndex = 5;
            // 
            // textGround
            // 
            this.textGround.Location = new System.Drawing.Point(224, 84);
            this.textGround.Name = "textGround";
            this.textGround.Size = new System.Drawing.Size(475, 31);
            this.textGround.TabIndex = 6;
            // 
            // textCoach
            // 
            this.textCoach.Location = new System.Drawing.Point(224, 144);
            this.textCoach.Name = "textCoach";
            this.textCoach.Size = new System.Drawing.Size(475, 31);
            this.textCoach.TabIndex = 7;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(224, 210);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(475, 31);
            this.textYear.TabIndex = 8;
            this.textYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textYear_KeyPress);
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(224, 266);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(475, 31);
            this.textLocation.TabIndex = 9;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(224, 332);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(275, 81);
            this.buttonAddTeam.TabIndex = 10;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textCoach);
            this.Controls.Add(this.textGround);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelCoach);
            this.Controls.Add(this.labelGround);
            this.Controls.Add(this.labelName);
            this.Name = "AddTeamForm";
            this.Text = "AddTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGround;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textGround;
        private System.Windows.Forms.TextBox textCoach;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Button buttonAddTeam;
    }
}