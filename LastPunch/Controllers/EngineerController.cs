using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch.Controllers
{
    public class EngineerController: ControllerBase, IControllerBase  // implements controller and interface
    {
        public override IQueryable getAllData()  //
        {
            return from p in db.Engineer select p; // select all fields in Engineer ent
        }

        public override void add()
        {  
            try
            {        
                Engineer Engineer = new Engineer();
            //setting the default company
                Engineer.CompanyID = getDefaultCompany().Id;
            
                EngineerForm EngineerViewer = new EngineerForm();
                EngineerViewer.mainEntity = Engineer;
                EngineerViewer.controller = this;

                if (EngineerViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.Engineer.Add(Engineer);
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
            Engineer Engineer = (from p in db.Engineer
                              where p.Id == id
                              select p).FirstOrDefault(); //search at database with query ID

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Engineer.Remove(Engineer);
                db.SaveChanges();
            }
        }

        public override void edit(int id)
        {
            Engineer Engineer = (from p in db.Engineer
                               where p.Id == id
                               select p).FirstOrDefault(); // 

            EngineerForm EngineerViewer = new EngineerForm();
            EngineerViewer.mainEntity = Engineer;
            EngineerViewer.controller = this;

            if (EngineerViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges();
            }
        }

    }
}
