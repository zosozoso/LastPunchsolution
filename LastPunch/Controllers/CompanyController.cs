using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch
{
    public class CompanyController: ControllerBase, IControllerBase
    {     
        public override IQueryable getAllData()
        {
            return from p in db.Company select p;   // select all fields in Company ent       
        }

        public override void add()
        {
            try
            {
                Company company = new Company();  // initilize entity
                CompanyForm companyViewer = new CompanyForm(); //
                companyViewer.mainEntity = company;
                companyViewer.controller = this;

                if (companyViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.Company.Add(company);
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
            Company Company = (from p in db.Company
                               where p.Id == id
                               select p).FirstOrDefault(); //search at database with query ID

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Company.Remove(Company);
                db.SaveChanges();
            }
        }

        public override void edit(int id)
        {
            Company company = (from p in db.Company
                               where p.Id == id
                               select p).FirstOrDefault();

            CompanyForm companyViewer = new CompanyForm();
            companyViewer.mainEntity = company;
            companyViewer.controller = this;

            if (companyViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges();
            }
        }
    }
}
