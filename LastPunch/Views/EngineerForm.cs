using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LastPunch.Views
{
    public partial class EngineerForm : LastPunch.Views.BaseForm
    {
        public EngineerForm()
        {
            InitializeComponent();
            tbPriceEn.Text = "0";
        }

        protected override void assignValuesToEntity()
        {
            Engineer Engineer = (Engineer)mainEntity;
            Engineer.Name = tbName.Text;
            Engineer.StatusName = tbStatusNameEn.Text;
            Engineer.Price = Convert.ToDecimal(tbPriceEn.Text);
        }

        protected override void loadEntity()
        {
            Engineer Engineer = (Engineer)mainEntity;
            tbName.Text = Engineer.Name;
            tbStatusNameEn.Text = Engineer.StatusName;

            if (Engineer.Price == null)
            {
                tbPriceEn.Text = "0";
            }
            else
            {
                tbPriceEn.Text = Engineer.Price.ToString();
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Condicional asking to fill out textboxes
            if (tbName.Text == "" || tbStatusName.Text == ""|| tbPriceEn.Text == "")
            {
                throw new System.InvalidOperationException("Please fill out the blank fields");
            }
        }

        private void EngineerForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPriceEn_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPriceEn_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void tbPriceEn_Leave(object sender, EventArgs e)
        {
            if (tbPriceEn.Text == "") // to avoid textBox to be null
            {
                tbPriceEn.Text = "0";
            }
        }
    }
}
