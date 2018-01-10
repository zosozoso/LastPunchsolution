using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch.Controllers
{
    public class ExpenseController: ControllerBase, IControllerBase // implements 
    {
        public override IQueryable getAllData()
        {
         return from p in db.Expense select p; // select all fields in Expense db
        }

        public override void add()
        {

            try
            {
                Expense Expense = new Expense(); // initilize entity
                ExpenseForm ExpenseViewer = new ExpenseForm();
                ExpenseViewer.mainEntity = Expense;
                ExpenseViewer.controller = this;

                if (ExpenseViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.Expense.Add(Expense);
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
             Expense Expense = (from p in db.Expense
                             where p.Id == id
                             select p).FirstOrDefault(); //search at database with query ID

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Expense.Remove(Expense);
                db.SaveChanges();
            }
        }

        public override void edit(int id)
        {
            Expense Expense = (from p in db.Expense   // consult
                               where p.Id == id
                               select p).FirstOrDefault();

            ExpenseForm ExpenseViewer = new ExpenseForm(); 
            ExpenseViewer.mainEntity = Expense;
            ExpenseViewer.controller = this;

            if (ExpenseViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges();
            }
        }
    }
}
