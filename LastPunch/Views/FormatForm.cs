using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LastPunch.Views
{
    public partial class FormatForm : LastPunch.Views.BaseForm
    {
        public FormatForm()
        {
            InitializeComponent();
        }

        protected override void assignValuesToEntity()  // assign to entity values of the following text
        {
            Format Format = (Format)mainEntity;
            Format.TypeName = tbTypeName.Text;
            Format.Price = Convert.ToDecimal(tbPricePerTrack.Text);
        }

        protected override void loadEntity()
        {
            Format Format = (Format)mainEntity;
            tbTypeName.Text = Format.TypeName;
            tbPricePerTrack.Text = Format.Price.ToString();

            if (Format.Price == null)
            {
                tbPricePerTrack.Text = "0";
            }
            else
            {
                tbPricePerTrack.Text = Format.Price.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Condicional asking to fill out textboxes
            if (tbTypeName.Text == "" || tbPricePerTrack.Text == "")

            {
                throw new System.InvalidOperationException("Please Please fill out the blank fields");
            }
        }            
                
        private void FormatForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPricePerTrack_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void tbPricePerTrack_Leave(object sender, EventArgs e)
        {
            if (tbPricePerTrack.Text == "") // to avoid textBox to be null
            {
                tbPricePerTrack.Text = "0";
            }
        }
    }
}

