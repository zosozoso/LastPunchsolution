using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch.Controllers
{
    public class OrderController: ControllerBase, IControllerBase
    {
        public override IQueryable getAllData()
        {
            return from p in db.Orders select p; // select all fields in space entity
        }

        public Orders getOrder(int id)
        {
            Orders Order = (from p in db.Orders
                             where p.Id == id
                             select p).FirstOrDefault(); //search at database with query ID

            return Order;
        }

        public override void add()
        {
            try
            {
                Orders LastOrder = db.Orders.ToList().LastOrDefault();
                       
                                
                Orders Orders = new Orders();
                // setting the default company
                Orders.CompanyID = getDefaultCompany().Id;

                OrdersForm OrdersViewer = new OrdersForm();
                OrdersViewer.mainEntity = Orders;
                OrdersViewer.controller = this;

                if (OrdersViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Orders.Id = LastOrder.Id + 1;  // assign ID from the last order +1
                    db.Orders.Add(Orders);
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
            {
                Orders Order = (from p in db.Orders
                                 where p.Id == id
                                 select p).FirstOrDefault(); //search at database with query ID

                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Orders.Remove(Order);
                    db.SaveChanges();
                }
            }
        }

        public override void edit(int id)
        {
            Orders Orders = (from p in db.Orders
                               where p.Id == id
                               select p).FirstOrDefault(); // db.=contex, LINQ sintax, select all fields Company ent

            OrdersForm OrdersViewer = new OrdersForm(); // show order form
            OrdersViewer.mainEntity = Orders;
            OrdersViewer.controller = this;

            if (OrdersViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges(); // save edited changes
            }
        }

        public void finishOrder(int id)
        {
            Orders order = (from p in db.Orders
                             where p.Id == id
                             select p).FirstOrDefault(); //search at database with query ID

            order.Finished = 1;
            order.DeliveryDate = DateTime.Now;  //set date
            Accountancy accountancy = new Accountancy();
            accountancy.CompanyID = getDefaultCompany().Id;
            accountancy.OrderID = order.Id;
            accountancy.Cost = order.Cost;
            accountancy.AccountDate = DateTime.Now; 

            db.Accountancy.Add(accountancy);
            db.SaveChanges();           
           
        }

        public List<Customer> getCustomers()
        {
            List<Customer> Customers = new List<Customer>(); // arraylist for List
            var query = from p in db.Customer select p; // linQ syntax, select all fields 
            foreach (var item in query) // go through all fields of the query
            {
                Customers.Add(item);  // //add rows
            }

            return Customers;
        }

        public List<Engineer> getEngineers()
        {
            List<Engineer> engineers = new List<Engineer>(); // arraylist for Engineers
            var query = from p in db.Engineer select p; // linQ syntax, select all fields 
            foreach (var item in query) // go through all fields of the query
            {
                engineers.Add(item); //add rows
            }

            return engineers;
        }

        public List<Format> getFormats()
        {
            List<Format> Formats = new List<Format>();  // arraylist of formats
            var query = from p in db.Format select p; // linQ syntax, select all fields
            foreach (var item in query) // go through all fields of the query
            {
                Formats.Add(item); //Add rows
            }

            return Formats;
        }
    }
}
