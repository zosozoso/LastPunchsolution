using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LastPunch.Views
{
    public partial class ExpenseForm : LastPunch.Views.BaseForm
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        protected override void assignValuesToEntity()
        {
            Expense Expense = (Expense)mainEntity;
            Expense.Name = tbNameEx.Text;
            Expense.Cost = Convert.ToDecimal(tbCost.Text);
        }

        protected override void loadEntity()
        {
            Expense Expense = (Expense)mainEntity;
            tbNameEx.Text = Expense.Name;
            tbCost.Text = Expense.Cost.ToString();

            if (Expense.Cost == null)
            {
                tbCost.Text = "0";
            }
            else
            {
                tbCost.Text = Expense.Cost.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Condicional asking to fill out textboxes
            if (tbNameEx.Text == "" || tbCost.Text == "")
            {
                throw new System.InvalidOperationException("Please fill out the blank fields");
            }

        }

        private void tbCost_Leave(object sender, EventArgs e)
        {
            if (tbCost.Text == "") // to avoid textBox to be null
            {
                tbCost.Text = "0";
            }
        }

        
        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }
    }
}
