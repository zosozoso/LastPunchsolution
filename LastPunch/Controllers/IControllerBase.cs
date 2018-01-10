using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPunch
{
    public interface IControllerBase
    
    {
        // this an interface acting as a template to make the inheritated controllers contain the following methods
        IQueryable getAllData();
        void add();
        void delete(int id);
        void edit(int id);
        void setEntity(object entity);
        object getEntity();
        Company getDefaultCompany();
    }
}
