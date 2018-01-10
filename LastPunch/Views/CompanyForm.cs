using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LastPunch.Views
{
    public partial class CompanyForm : BaseForm
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        protected override void assignValuesToEntity() // send textboxes info to entity
        {
            Company company = (Company)mainEntity;
            company.Name = tbName.Text;
            company.Phone = tbPhoneCom.Text;
            company.Street = tbStreet.Text;
            //company.Country = tbCountry.Text;
            company.PostCode = tbPostCode.Text;
            company.CIF = tbNIE.Text;
        }

        protected override void loadEntity() // load entity data on form
        {
            Company company = (Company)mainEntity;
            tbName.Text = company.Name;
            tbPhoneCom.Text = company.Phone;
            tbStreet.Text = company.Street;
            //tbCountry.Text = company.Country;
            tbPostCode.Text = company.PostCode;
            tbNIE.Text = company.CIF;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Condicional asking to fill out textboxes
                if (tbName.Text == "" || tbPhoneCom.Text == "" || tbStreet.Text == "" || tbCountry.Text == ""
                    || tbPostCode.Text == "" || tbNIE.Text == "")
                {
                    throw new System.InvalidOperationException("Please fill out the blank boxes");
                }
            }


        }

        private void tbNIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }
    }

}
