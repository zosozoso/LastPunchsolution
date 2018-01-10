namespace LastPunch.Views
{
    partial class EngineerForm
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
            this.tbPriceEn = new System.Windows.Forms.TextBox();
            this.tbStatusNameEn = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatusName = new System.Windows.Forms.Label();
            this.tbNameEng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPriceEn
            // 
            this.tbPriceEn.Location = new System.Drawing.Point(209, 162);
            this.tbPriceEn.MaxLength = 20;
            this.tbPriceEn.Name = "tbPriceEn";
            this.tbPriceEn.Size = new System.Drawing.Size(122, 20);
            this.tbPriceEn.TabIndex = 31;
            this.tbPriceEn.Text = "0\r\n";
            this.tbPriceEn.TextChanged += new System.EventHandler(this.tbPriceEn_TextChanged);
            this.tbPriceEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceEn_KeyPress);
            this.tbPriceEn.Leave += new System.EventHandler(this.tbPriceEn_Leave);
            // 
            // tbStatusNameEn
            // 
            this.tbStatusNameEn.Location = new System.Drawing.Point(209, 120);
            this.tbStatusNameEn.Name = "tbStatusNameEn";
            this.tbStatusNameEn.Size = new System.Drawing.Size(326, 20);
            this.tbStatusNameEn.TabIndex = 30;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(209, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(326, 20);
            this.tbName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price per track";
            // 
            // tbStatusName
            // 
            this.tbStatusName.AutoSize = true;
            this.tbStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusName.Location = new System.Drawing.Point(20, 111);
            this.tbStatusName.Name = "tbStatusName";
            this.tbStatusName.Size = new System.Drawing.Size(156, 29);
            this.tbStatusName.TabIndex = 27;
            this.tbStatusName.Text = "Status name";
            // 
            // tbNameEng
            // 
            this.tbNameEng.AutoSize = true;
            this.tbNameEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameEng.Location = new System.Drawing.Point(20, 70);
            this.tbNameEng.Name = "tbNameEng";
            this.tbNameEng.Size = new System.Drawing.Size(82, 29);
            this.tbNameEng.TabIndex = 28;
            this.tbNameEng.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Engineer";
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 395);
            this.Controls.Add(this.tbPriceEn);
            this.Controls.Add(this.tbStatusNameEn);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatusName);
            this.Controls.Add(this.tbNameEng);
            this.Controls.Add(this.label1);
            this.Name = "EngineerForm";
            this.Text = "Engineer form";
            this.Load += new System.EventHandler(this.EngineerForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbNameEng, 0);
            this.Controls.SetChildIndex(this.tbStatusName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.tbStatusNameEn, 0);
            this.Controls.SetChildIndex(this.tbPriceEn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPriceEn;
        private System.Windows.Forms.TextBox tbStatusNameEn;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tbStatusName;
        private System.Windows.Forms.Label tbNameEng;
        private System.Windows.Forms.Label label1;
    }
}
