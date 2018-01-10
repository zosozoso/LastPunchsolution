using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Views;
using System.Windows.Forms;

namespace LastPunch.Controllers
{
    public class FormatController: ControllerBase, IControllerBase // implements controller and interface
    {
        public override IQueryable getAllData()
        {
            return from p in db.Format select p;
        }

        public override void add()
        {
            try
            {
                Format Format = new Format(); // initilize entity
                FormatForm FormatViewer = new FormatForm();
                FormatViewer.mainEntity = Format;
                FormatViewer.controller = this;

                if (FormatViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.Format.Add(Format); //add format to db
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
            Format Format = (from p in db.Format
                             where p.Id == id
                             select p).FirstOrDefault(); //search at database with query ID

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Format.Remove(Format);
                db.SaveChanges();
            }            
        }

        public override void edit(int id)
        {
            Format Format = (from p in db.Format
                               where p.Id == id
                               select p).FirstOrDefault();

            FormatForm FormatViewer = new FormatForm();
            FormatViewer.mainEntity = Format;
            FormatViewer.controller = this;

            if (FormatViewer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveChanges();
            }
        }

    }
}
