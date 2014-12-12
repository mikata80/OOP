using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Employee :IPerson,IEmploee
    {
        int id;
        string name;
        string lastname;
        Department deparment;
        private double salary;
  

        public Employee(int id, string name, string lastname, double sallary, Department deparment)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastname;
            this.Salary = salary;
            this.Deparment = deparment;
        }

        public Employee()
        {
            // TODO: Complete member initialization
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Emploee Id must be > 0");
                }
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentOutOfRangeException("Emploee name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentOutOfRangeException("Emploee last name cannot be empty!");
                }
                this.lastname = value;
            }
        }

        Department Deparment
        {
            get
            {
                return this.deparment;
            }
            set
            {
                this.deparment = value;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Employee salart must be > 0!");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + " salary = {0}", Salary);
        }

    }
}
