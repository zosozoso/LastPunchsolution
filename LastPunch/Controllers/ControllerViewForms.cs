using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastPunch.Controllers;

namespace LastPunch
{
    public class ControllerViewForms
    {
        private BaseViewForm baseViewForm;

        public void createBaseViewForm(object entity, IControllerBase controllerBase)
        {
            controllerBase.setEntity(entity); // send controller and entity to baseviewform 
            baseViewForm = new BaseViewForm(controllerBase);
            baseViewForm.Show();

        } // create base view form for each entity
        

        public void showCompany()
        { 
            createBaseViewForm(new Company(), new CompanyController());            
        }

        public void showCustomer()
        {
            createBaseViewForm(new Customer(), new CustomerController());
        }

        public void showEngineer()
        {
            createBaseViewForm(new Engineer(), new EngineerController());
        }

        public void showExpense()
        {
            createBaseViewForm(new Expense(), new ExpenseController());
        }

        public void showFormat()
        {
            createBaseViewForm(new Format(), new FormatController());
        }

        public void showOrder()
        {
            createBaseViewForm(new Orders(), new OrderController());
        }

    }
}
