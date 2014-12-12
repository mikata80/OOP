using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Person :IPerson
    {
        private int id;
        private string name;
        private string lastname;

        public Person(int id, string name, string lastname)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastname;
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
                    throw new ArgumentOutOfRangeException("Person Id must be > 0");
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
                    throw new ArgumentOutOfRangeException("Person name cannot be empty!");
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
                    throw new ArgumentOutOfRangeException("Person last name cannot be empty!");
                }
                this.lastname = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}. {1} {2}", Id, Name, LastName);
        }
    }
}
