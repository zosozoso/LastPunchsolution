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
    public partial class OrderViewForm : Form
    {
        private OrderController controllerBase;

        public OrderViewForm(IControllerBase controller)
        {
            InitializeComponent();
            controllerBase = (OrderController) controller; // open view form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listData()
        {
            this.listView1.Items.Clear();

            foreach (var item in controllerBase.getAllData())
            {
                Orders order = (Orders)item;                

                ListViewItem newList = new ListViewItem(order.Id.ToString());  // add to row all the following data
                newList.SubItems.Add(order.ProjectName);
                newList.SubItems.Add(order.TotalSongs.ToString());
                newList.SubItems.Add(order.Cost.ToString());
                newList.SubItems.Add(order.Engineer.Name);
                newList.SubItems.Add(order.Customer.Name);
                newList.SubItems.Add(order.Format.TypeName);                            
                newList.SubItems.Add(Convert.ToBoolean(order.Finished).ToString()); // Boolean for finishsing the order

                if (order.Finished == 0)
                {
                    newList.ForeColor = Color.White;
                    newList.BackColor = Color.Red;   // color when order is finished
                }
                else
                {
                    newList.ForeColor = Color.Black; 
                    newList.BackColor = Color.White;
                }

                this.listView1.Items.Add(newList);
            }
        }

        private void OrderViewForm_Shown(object sender, EventArgs e)
        {
            listData();
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                int id = -1; // if ID is not found add -1 to show
                int.TryParse(this.listView1.SelectedItems[0].SubItems[0].Text, out id);
                controllerBase.finishOrder(id);
                MessageBox.Show("Order " + id.ToString() + " has been finished");
                btnFinishOrder.Enabled = false;
                listData();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                int id = -1;
                int.TryParse(this.listView1.SelectedItems[0].SubItems[0].Text, out id);
                Orders order = controllerBase.getOrder(id);
                btnFinishOrder.Enabled = (order.Finished == 0); // Finish button gets enabled when order is selected
            }
        }
    }
}
