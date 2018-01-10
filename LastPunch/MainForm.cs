using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastPunch.Controllers;
using LastPunch.Views;

namespace LastPunch
{
    public partial class MainForm : Form
    {
        private ControllerViewForms mg = new ControllerViewForms(); // initilize controller view form

        public MainForm()
        {
            InitializeComponent(); 
        }
       
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mg.showCompany();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mg.showCustomer();
        }

        private void engineersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mg.showEngineer();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mg.showExpense();
        }

        private void formatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mg.showFormat();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OrderController orderController = new OrderController(); // show orders form
            orderController.setEntity(new Orders());
            orderController.add();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderViewForm orderViewForm = new OrderViewForm(new OrderController()); // show orders view form
            orderViewForm.ShowDialog();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AccountancyController accountancyController = new AccountancyController(); // show accountancy form
            accountancyController.setEntity(new Accountancy());
            accountancyController.add();
        }

        private void viewAccountancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountancyViewForm accountancyViewForm = new AccountancyViewForm(new AccountancyController());  // show accountancy view form          
            accountancyViewForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void entitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
