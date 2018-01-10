using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Collections;
//using System.Data.SqlClient;

namespace LastPunch
{
    public partial class BaseViewForm : Form
    { 
        private object mainEntity { get; set; } // pass entity
        private IControllerBase controllerBase { get; set; }
        private List<String> fields; // arraylist for storing entity fields

        public BaseViewForm(IControllerBase controller)  // constructor as parameter
        {
            InitializeComponent();
            controllerBase = controller;
            mainEntity = controller.getEntity();
            fields = getFields();            

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerBase.add(); 
            listData();  // refresh data from the database
        }

        private void listData() // gets all data from entity and populates each row on the list view
        {
            this.listView1.Items.Clear();

            foreach (var item in controllerBase.getAllData())
            {
                string[] row = new string[fields.Count];                
                for (int i = 0; i < fields.Count; i++)
                {
                    var value = item.GetType().GetProperty(fields[i]).GetValue(item, null);
                    if (value != null)
                    {
                        row[i] = value.ToString();
                    }
                }
                ListViewItem lvi = new ListViewItem(row);  // insert row in grid
                this.listView1.Items.Add(lvi);
            }
        }

        private List<String> getFields()  // retrieves the properties from the selected entity and avoids the
                                          //  Icollection properties
                                             
        {
            List<String> f = mainEntity.GetType().GetProperties()
                           .Where(property => property.GetType() != typeof(ICollection<object>))
                           .Select(property => property.Name)                           
                           .ToList();
            return f;
        }

        private void createColums()  // creates columns on listview from the entity fields
        {            
            foreach (var field in fields)
            {
                ColumnHeader columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                columnHeader.Text = field;
                
                this.listView1.Columns.Add(columnHeader);
            }
        }

        private void BaseViewForm_Shown(object sender, EventArgs e)
        {
            createColums();
            listData(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (this.listView1.SelectedItems.Count > 0) {  //get ID from list new row
                int id = -1;
                int.TryParse(this.listView1.SelectedItems[0].SubItems[0].Text, out id);
                controllerBase.edit(id);
                listData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                int id = -1;
                int.TryParse(this.listView1.SelectedItems[0].SubItems[0].Text, out id); // get ID
                controllerBase.delete(id);
                listData();
            }            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
