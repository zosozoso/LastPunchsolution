namespace LastPunch.Views
{
    partial class OrdersForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.cbLoud = new System.Windows.Forms.CheckBox();
            this.cbDin = new System.Windows.Forms.CheckBox();
            this.cbHigh = new System.Windows.Forms.CheckBox();
            this.cbLow = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTracks = new System.Windows.Forms.TextBox();
            this.tbTotalsongs = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormats = new System.Windows.Forms.ComboBox();
            this.cbEngineer = new System.Windows.Forms.ComboBox();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Text = "Create order";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(304, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 16);
            this.label16.TabIndex = 105;
            this.label16.Text = "£££";
            // 
            // cbLoud
            // 
            this.cbLoud.AutoSize = true;
            this.cbLoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoud.Location = new System.Drawing.Point(284, 203);
            this.cbLoud.Name = "cbLoud";
            this.cbLoud.Size = new System.Drawing.Size(61, 20);
            this.cbLoud.TabIndex = 95;
            this.cbLoud.Text = "Loud";
            this.cbLoud.UseVisualStyleBackColor = true;
            // 
            // cbDin
            // 
            this.cbDin.AutoSize = true;
            this.cbDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDin.Location = new System.Drawing.Point(195, 203);
            this.cbDin.Name = "cbDin";
            this.cbDin.Size = new System.Drawing.Size(83, 20);
            this.cbDin.TabIndex = 94;
            this.cbDin.Text = "Dinamic";
            this.cbDin.UseVisualStyleBackColor = true;
            // 
            // cbHigh
            // 
            this.cbHigh.AutoSize = true;
            this.cbHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHigh.Location = new System.Drawing.Point(269, 173);
            this.cbHigh.Name = "cbHigh";
            this.cbHigh.Size = new System.Drawing.Size(59, 20);
            this.cbHigh.TabIndex = 93;
            this.cbHigh.Text = "High";
            this.cbHigh.UseVisualStyleBackColor = true;
            // 
            // cbLow
            // 
            this.cbLow.AutoSize = true;
            this.cbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLow.Location = new System.Drawing.Point(195, 173);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(54, 20);
            this.cbLow.TabIndex = 92;
            this.cbLow.Text = "Low";
            this.cbLow.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 20);
            this.label15.TabIndex = 98;
            this.label15.Text = "Format";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(194, 373);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(104, 20);
            this.tbCost.TabIndex = 99;
            this.tbCost.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Loundness level";
            // 
            // tbTracks
            // 
            this.tbTracks.Location = new System.Drawing.Point(195, 134);
            this.tbTracks.MaxLength = 100;
            this.tbTracks.Name = "tbTracks";
            this.tbTracks.Size = new System.Drawing.Size(324, 20);
            this.tbTracks.TabIndex = 91;
            this.tbTracks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTracks_KeyPress);
            // 
            // tbTotalsongs
            // 
            this.tbTotalsongs.Location = new System.Drawing.Point(195, 106);
            this.tbTotalsongs.MaxLength = 25;
            this.tbTotalsongs.Name = "tbTotalsongs";
            this.tbTotalsongs.Size = new System.Drawing.Size(54, 20);
            this.tbTotalsongs.TabIndex = 90;
            this.tbTotalsongs.Text = "0";
            this.tbTotalsongs.TextChanged += new System.EventHandler(this.tbTotalsongs_TextChanged);
            this.tbTotalsongs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalsongs_KeyPress_1);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(195, 76);
            this.tbProjectName.MaxLength = 100;
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(324, 20);
            this.tbProjectName.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Level of Processing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 84;
            this.label12.Text = "Engineer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 85;
            this.label13.Text = "Customer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tracks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Total songs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Project name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 75;
            this.label1.Text = "Create new Order";
            // 
            // cbFormats
            // 
            this.cbFormats.FormattingEnabled = true;
            this.cbFormats.Location = new System.Drawing.Point(194, 316);
            this.cbFormats.Name = "cbFormats";
            this.cbFormats.Size = new System.Drawing.Size(155, 21);
            this.cbFormats.TabIndex = 98;
            this.cbFormats.SelectedIndexChanged += new System.EventHandler(this.cbFormats_SelectedIndexChanged);
            // 
            // cbEngineer
            // 
            this.cbEngineer.FormattingEnabled = true;
            this.cbEngineer.Location = new System.Drawing.Point(194, 286);
            this.cbEngineer.Name = "cbEngineer";
            this.cbEngineer.Size = new System.Drawing.Size(155, 21);
            this.cbEngineer.TabIndex = 97;
            this.cbEngineer.SelectedIndexChanged += new System.EventHandler(this.cbEngineer_SelectedIndexChanged);
            // 
            // cbCustomers
            // 
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(194, 254);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(324, 21);
            this.cbCustomers.TabIndex = 96;
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 416);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.cbEngineer);
            this.Controls.Add(this.cbFormats);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbLoud);
            this.Controls.Add(this.cbDin);
            this.Controls.Add(this.cbHigh);
            this.Controls.Add(this.cbLow);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbTracks);
            this.Controls.Add(this.tbTotalsongs);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "OrdersForm";
            this.Text = "Create new order";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbProjectName, 0);
            this.Controls.SetChildIndex(this.tbTotalsongs, 0);
            this.Controls.SetChildIndex(this.tbTracks, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.tbCost, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.cbLow, 0);
            this.Controls.SetChildIndex(this.cbHigh, 0);
            this.Controls.SetChildIndex(this.cbDin, 0);
            this.Controls.SetChildIndex(this.cbLoud, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.cbFormats, 0);
            this.Controls.SetChildIndex(this.cbEngineer, 0);
            this.Controls.SetChildIndex(this.cbCustomers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbLoud;
        private System.Windows.Forms.CheckBox cbDin;
        private System.Windows.Forms.CheckBox cbHigh;
        private System.Windows.Forms.CheckBox cbLow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTracks;
        private System.Windows.Forms.TextBox tbTotalsongs;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormats;
        private System.Windows.Forms.ComboBox cbEngineer;
        private System.Windows.Forms.ComboBox cbCustomers;
    }
}
