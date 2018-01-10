using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;


namespace LastPunch.Controllers
{
    public class AccountancyController : ControllerBase, IControllerBase
    {
        public override IQueryable getAllData()
        {
            return from p in db.Accountancy select p;
        }

        public override void add()
        {
            try
            {
                Accountancy accountancy = new Accountancy();
                accountancy.CompanyID = getDefaultCompany().Id; // get default ID from table

                AddExpenseToAccountancyForm addExpenseForm = new AddExpenseToAccountancyForm();
                addExpenseForm.mainEntity = accountancy;
                addExpenseForm.controller = this;

                if (addExpenseForm.ShowDialog() == System.Windows.Forms.DialogResult.OK) // Save input at expense
                {
                    db.Accountancy.Add(accountancy);
                    db.SaveChanges();
                }
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void delete(int id)
        {

        }

        public override void edit(int id)
        {

        }

        public List<Expense> getExpenses() // get expenses from expense form
        {
            List<Expense> Expenses = new List<Expense>(); // Arraylist for comboBo
            var query = from p in db.Expense select p; // linQ syntax, select all fields in ent expense
            foreach (var item in query) // go through all fields of the query
            {
                Expenses.Add(item);
            }

            return Expenses;
        }

    }
}
