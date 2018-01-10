using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LastPunch.Controllers;


namespace LastPunch.Views
{
    public partial class OrdersForm : LastPunch.Views.BaseForm
    {
        private OrderController orderController; // variables for dinamic data
        private Double TotalCost = 0;
        private Engineer engineerSelected;
        private Format formatSelected;

        public OrdersForm()
        {
            InitializeComponent();
        }

        protected override void assignValuesToEntity()
        {
            Customer customer = (cbCustomers.SelectedItem as dynamic).Value; 

            Orders Orders = (Orders)mainEntity;  // main entity gets casted to order to set properties
            Orders.ProjectName = tbProjectName.Text;
            Orders.Cost = Convert.ToDecimal(TotalCost);
            Orders.CustomerId = customer.Id;
            Orders.EngineerID = engineerSelected.Id;
            Orders.Finished = 0;
            Orders.FormatID = formatSelected.Id;
            Orders.TotalSongs = Convert.ToInt32(tbTotalsongs.Text);
            Orders.Tracks = tbTracks.Text;

            if (cbLow.Checked)
            {
                Orders.LevelProcessing = 0;
            } else
            {
                if (cbHigh.Checked)
                {
                    Orders.LevelProcessing = 1; // checkbox to store the level processing info
                }
            }

            if (cbDin.Checked)
            {
                Orders.LoudnessLevel = 0;
            }
            else
            {
                if (cbLoud.Checked)
                {
                    Orders.LoudnessLevel = 1; // chechbox to store loundness
                }
            }
        }

        private void updateTotalCost()
        {
            Double formatPrice = 0;
            Double engineerPrice = 0;
            int totalSongs = 0;

            if (tbTotalsongs.Text != "")  // Error prevention 
            {
                totalSongs = Convert.ToInt32(tbTotalsongs.Text);

                if (formatSelected != null)
                {
                    formatPrice = (Double)formatSelected.Price;
                }

                if (engineerSelected != null)
                {
                    engineerPrice = (Double)engineerSelected.Price;
                }
            }


            TotalCost = totalSongs * (formatPrice + engineerPrice); // calculte total cost
                tbCost.Text = TotalCost.ToString();
        }

        protected override void loadEntity()
        {
            tbCost.Text = TotalCost.ToString();

            
            orderController = (OrderController)controller;

            cbEngineer.DisplayMember = "Text";
            cbEngineer.ValueMember = "Value";
            foreach (var item in orderController.getEngineers()) //arraylist, it ask the contorller to bring engineer info
            {
                cbEngineer.Items.Add(new { Text = item.Name, Value = item });
            }

            cbFormats.DisplayMember = "Text";
            cbFormats.ValueMember = "Value";
            foreach (var item in orderController.getFormats()) //arralistn it ask the contorller to bring format info
            {
                cbFormats.Items.Add(new { Text = item.TypeName, Value = item });
            }

            cbCustomers.DisplayMember = "Text";
            cbCustomers.ValueMember = "Value";
            foreach (var item in orderController.getCustomers()) //arraslist
            {
                cbCustomers.Items.Add(new { Text = item.Name, Value = item });
            }
        }

        private void cbEngineer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEngineer.SelectedItem != null)
            {
                engineerSelected = (cbEngineer.SelectedItem as dynamic).Value; // engineer selected updates cost
                updateTotalCost();
            }
        }

        private void cbFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormats.SelectedItem != null)
            {
                formatSelected = (cbFormats.SelectedItem as dynamic).Value; //format selected updates cost
                updateTotalCost();
            }
        }

        private void tbTotalsongs_TextChanged(object sender, EventArgs e)
        {
            updateTotalCost();

        }
        private void tbTotalsongs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Condicional asking to fill out textboxes and ComboBoxes
            if (tbProjectName.Text == "" || tbTotalsongs.Text == "" || tbTracks.Text == "" || cbLow.Checked != true && cbHigh.Checked != true
                || cbLow.Checked == true && cbHigh.Checked == true || cbDin.Checked != true && cbLoud.Checked != true || cbDin.Checked == true && cbLoud.Checked == true
                ||cbCustomers.Text==""||cbEngineer.Text==""||cbFormats.Text=="")
            {
                throw new System.InvalidOperationException("Please Please fill out the blank fields");
            }
        }

        private void tbTracks_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void tbTotalsongs_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // it avoids enter any string
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

