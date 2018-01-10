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


namespace LastPunch.Views
{
    public partial class AccountancyViewForm : Form
    {
        private IControllerBase controllerBase;

        public AccountancyViewForm(IControllerBase controller)
        {
            InitializeComponent();
            controllerBase = (AccountancyController)controller;
        }

        private void AccountancyViewForm_Shown(object sender, EventArgs e)
        {
            listData();
        }

        private void listData()
        {
            Double TotalExpenses = 0; // accountancy variables
            Double TotalPayments = 0;
            Double Total = 0;

            this.listView1.Items.Clear();

            foreach (var item in controllerBase.getAllData()) // get data from accountancy entity and insert rows on listview 
            {
                Accountancy accountancy = (Accountancy)item;

                ListViewItem newList = new ListViewItem(accountancy.Id.ToString());
                newList.SubItems.Add(accountancy.AccountDate.ToString());
                newList.SubItems.Add(accountancy.OrderID.ToString());
                if (accountancy.Expense != null)
                    newList.SubItems.Add(accountancy.Expense.Name);
                else
                    newList.SubItems.Add("");
                newList.SubItems.Add(accountancy.Cost.ToString());
                newList.ForeColor = Color.White;

                if (accountancy.Expense != null)
                {
                    newList.BackColor = Color.Red; // label color
                    TotalExpenses = TotalExpenses + Convert.ToDouble(accountancy.Expense.Cost);
                }
                else
                {
                    if (accountancy.Orders != null)
                    {
                        newList.BackColor = Color.Green; // label color
                        TotalPayments = TotalPayments + Convert.ToDouble(accountancy.Orders.Cost);
                    }
                }

                this.listView1.Items.Add(newList);                
            }

            lbExpenses.Text = TotalExpenses.ToString(); // show expenses in label
            lbPayment.Text = TotalPayments.ToString(); // show paymment in label
            Total = TotalPayments - TotalExpenses; // show total balance in label
            lbTotal.Text = Total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
