using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastPunch
{
    public abstract class ControllerBase: IControllerBase //implements from interface Icontrollerbase 
    {
        
        protected dblastpunchModelEntities db = new dblastpunchModelEntities(); //db contex, conexion chain

        private object entity;

        public Company getDefaultCompany()
        {
            
            Company Company = (from p in db.Company            
                               select p).FirstOrDefault(); // db.=contex, select all fields Company ent

            return Company;
        }

        public abstract IQueryable getAllData(); // abstract methods to be implemented by forms

        public abstract void add();

        public abstract void delete(int id);

        public abstract void edit(int id);

        public object getEntity()
        {
            return entity;
        }

        public void setEntity(object pEntity)
        {
            entity = pEntity;
        }        
    }
}
