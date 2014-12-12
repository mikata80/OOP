using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager
    {
        
        List<Employee> employees;
        public Manager(List<Employee> employees)
        {
            this.employees = employees;
        }



        public int Id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = Id;
            }
        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
             
            }
        }

        public string LastName
        {
            get
            {
             
            }
            set
            {
             
            }
        }
    }
}
