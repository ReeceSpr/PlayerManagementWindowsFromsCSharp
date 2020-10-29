namespace Assignment_3
{
    partial class AddPlayerForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelBDate = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBPlace = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textSName = new System.Windows.Forms.TextBox();
            this.dateBDate = new System.Windows.Forms.DateTimePicker();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.textBPlace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 272);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(680, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Player";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(95, 31);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(605, 31);
            this.textID.TabIndex = 1;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textID_KeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(44, 25);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(348, 79);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(147, 25);
            this.labelSName.TabIndex = 4;
            this.labelSName.Text = "Second Name";
            // 
            // labelBDate
            // 
            this.labelBDate.AutoSize = true;
            this.labelBDate.Location = new System.Drawing.Point(18, 122);
            this.labelBDate.Name = "labelBDate";
            this.labelBDate.Size = new System.Drawing.Size(107, 25);
            this.labelBDate.TabIndex = 5;
            this.labelBDate.Text = "Birth Date";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(18, 171);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(74, 25);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(384, 171);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(79, 25);
            this.labelWeight.TabIndex = 7;
            this.labelWeight.Text = "Weight";
            // 
            // labelBPlace
            // 
            this.labelBPlace.AutoSize = true;
            this.labelBPlace.Location = new System.Drawing.Point(18, 226);
            this.labelBPlace.Name = "labelBPlace";
            this.labelBPlace.Size = new System.Drawing.Size(116, 25);
            this.labelBPlace.TabIndex = 8;
            this.labelBPlace.Text = "Birth Place";
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(140, 76);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(200, 31);
            this.textFName.TabIndex = 9;
            // 
            // textSName
            // 
            this.textSName.Location = new System.Drawing.Point(501, 79);
            this.textSName.Name = "textSName";
            this.textSName.Size = new System.Drawing.Size(200, 31);
            this.textSName.TabIndex = 10;
            // 
            // dateBDate
            // 
            this.dateBDate.CustomFormat = "dd/MM/yyyy";
            this.dateBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBDate.Location = new System.Drawing.Point(140, 122);
            this.dateBDate.Name = "dateBDate";
            this.dateBDate.Size = new System.Drawing.Size(450, 31);
            this.dateBDate.TabIndex = 11;
            this.dateBDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(140, 171);
            this.numericHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(200, 31);
            this.numericHeight.TabIndex = 12;
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(501, 169);
            this.numericWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(200, 31);
            this.numericWeight.TabIndex = 13;
            // 
            // textBPlace
            // 
            this.textBPlace.Location = new System.Drawing.Point(140, 226);
            this.textBPlace.Name = "textBPlace";
            this.textBPlace.Size = new System.Drawing.Size(560, 31);
            this.textBPlace.TabIndex = 14;
            // 
            // AddPlayerForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 365);
            this.Controls.Add(this.textBPlace);
            this.Controls.Add(this.numericWeight);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.dateBDate);
            this.Controls.Add(this.textSName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.labelBPlace);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelBDate);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelBDate;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBPlace;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textSName;
        private System.Windows.Forms.DateTimePicker dateBDate;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.TextBox textBPlace;
    }
}