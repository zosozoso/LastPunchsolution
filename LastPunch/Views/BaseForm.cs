using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LastPunch.Views
{
    public partial class BaseForm : Form  // basic form for entities, 
    {
        public IControllerBase controller; // interface
        public object mainEntity;

        public BaseForm() 
        {            
            InitializeComponent();
        }        

        private void BaseForm_Shown(object sender, EventArgs e)
        {
            loadEntity();  // load entity data on form
        }

        protected virtual void loadEntity()
        {

        }

        protected virtual void assignValuesToEntity()
        {
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            assignValuesToEntity(); // send textboxes info to entity
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
