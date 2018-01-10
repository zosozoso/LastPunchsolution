using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LastPunch.Views
{
    public partial class CustomerForm : LastPunch.Views.BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        protected override void assignValuesToEntity() // send textboxes info to entity
        {
            Customer Customer = (Customer)mainEntity;
            Customer.Name = tbName.Text;
            Customer.Phone = tbPhone.Text;
            Customer.Street = tbStreet.Text;
            Customer.Country = tbCountry.Text;
            Customer.PostCode = tbPostCode.Text;
            Customer.SureName = tbSurname.Text;            
        }

        protected override void loadEntity() // load entity data on form
        {
            Customer Customer = (Customer)mainEntity;
            tbName.Text = Customer.Name;
            tbPhone.Text = Customer.Phone;
            tbStreet.Text = Customer.Street;
            tbCountry.Text = Customer.Country;
            tbPostCode.Text = Customer.PostCode;
            tbSurname.Text = Customer.SureName;            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            {
                // Condicional asking to fill out textboxes
                if (tbName.Text == "" || tbSurname.Text == "" || tbPhone.Text == "" || tbStreet.Text == "" || tbCountry.Text == "")
                {
                    throw new System.InvalidOperationException("Please fill out the blank fields");
                }

                // if statement to check if the input data is a string



            }
            }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text == "") // to avoid textBox to be null
            {
                tbPhone.Text = "0";
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

