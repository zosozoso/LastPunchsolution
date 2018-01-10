using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch.Controllers
{
    public class CustomerController : ControllerBase, IControllerBase
    {        
        public override IQueryable getAllData()
        {
            return from p in db.Customer select p;
        }


        public override void add()
        {

            try
            {
                Customer Customer = new Customer();
                // Setting the default company
                Customer.CompanyID = getDefaultCompany().Id;

                CustomerForm CustomerViewer = new CustomerForm();
                CustomerViewer.mainEntity = Customer;
                CustomerViewer.controller = this;

                if (CustomerViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    db.Customer.Add(Customer);
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
            Customer Customer = (from p in db.Customer
                              where p.Id == id
                              select p).FirstOrDefault(); //search at database with query ID

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Customer.Remove(Customer);
                db.SaveChanges();
            }
        }

        public override void edit(int id)
        {
            Customer Customer = (from p in db.Customer
                               where p.Id == id
                               select p).FirstOrDefault();

            CustomerForm CustomerViewer = new CustomerForm();
            CustomerViewer.mainEntity = Customer;
            CustomerViewer.controller = this;

            if (CustomerViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges();
            }
        }

    }
}
