using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LastPunch.Views;
using LastPunch.Controllers;

namespace LastPunch.Views
{
    public partial class AddExpenseToAccountancyForm : BaseForm
    {
        private Expense expenseSelected;

        public AddExpenseToAccountancyForm()
        {
            InitializeComponent();            
            
        }

        protected override void assignValuesToEntity() // send textboxes info to entity
        {
            Accountancy Accountancy = (Accountancy)mainEntity;
            Accountancy.ExpenseID = expenseSelected.Id;
            Accountancy.Cost = Convert.ToDecimal(tbCost.Text);
            Accountancy.AccountDate = Convert.ToDateTime(tbDate.Text);
        }

        protected override void loadEntity() // load entity data on form
        {
            base.loadEntity();

            tbDate.Text = DateTime.Now.ToString();

            AccountancyController accountancyController = (AccountancyController)controller;

            cbExpenses.DisplayMember = "Text";
            cbExpenses.ValueMember = "Value";
            foreach (var item in accountancyController.getExpenses())
            {
                cbExpenses.Items.Add(new { Text = item.Name, Value = item });
            }
        }

        private void cbExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbExpenses.SelectedItem != null)
            {
                expenseSelected = (cbExpenses.SelectedItem as dynamic).Value;
                tbCost.Text = expenseSelected.Cost.ToString(); 
            }
        }

        private void AddExpenseToAccountancyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Condicional asking to fill out textboxes and ComboBoxes
            if (cbExpenses.Text == "" || tbDate.Text == "" || tbCost.Text == "")
            {
                throw new System.InvalidOperationException("Please Please fill out the blank fields");
            }
        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void tbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }
    }

    
}
