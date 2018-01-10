namespace LastPunch.Views
{
    partial class FormatForm
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
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatusName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPricePerTrack = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(207, 82);
            this.tbTypeName.MaxLength = 15;
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(302, 20);
            this.tbTypeName.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Price per track";
            // 
            // tbStatusName
            // 
            this.tbStatusName.AutoSize = true;
            this.tbStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusName.Location = new System.Drawing.Point(17, 73);
            this.tbStatusName.Name = "tbStatusName";
            this.tbStatusName.Size = new System.Drawing.Size(148, 29);
            this.tbStatusName.TabIndex = 55;
            this.tbStatusName.Text = "Type Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 53;
            this.label1.Text = "Format";
            // 
            // tbPricePerTrack
            // 
            this.tbPricePerTrack.Location = new System.Drawing.Point(207, 129);
            this.tbPricePerTrack.Name = "tbPricePerTrack";
            this.tbPricePerTrack.Size = new System.Drawing.Size(100, 20);
            this.tbPricePerTrack.TabIndex = 59;
            this.tbPricePerTrack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricePerTrack_KeyPress);
            this.tbPricePerTrack.Leave += new System.EventHandler(this.tbPricePerTrack_Leave);
            // 
            // FormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 398);
            this.Controls.Add(this.tbPricePerTrack);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatusName);
            this.Controls.Add(this.label1);
            this.Name = "FormatForm";
            this.Text = "Format";
            this.Load += new System.EventHandler(this.FormatForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbStatusName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbTypeName, 0);
            this.Controls.SetChildIndex(this.tbPricePerTrack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tbStatusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPricePerTrack;
    }
}
