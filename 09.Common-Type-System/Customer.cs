using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer : ICloneable, IComparable
    {
        // first name, middle name and last name, ID (EGN), permanent address, mobile phone, e-mai
        public string FirstName { get; set; }

        public string MiddleName { get; set; }  

        public string LastName { get; set; }

        public long EGN { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<Payment> payments;

        public CustomerType customerType;

        public Customer()
        {

        }

        public Customer(string fName, string mName, string lName, long egn, string pAddress,
            string mPhome, string email, List<Payment> payts, CustomerType cType)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.EGN = egn;
            this.PermanentAddress = pAddress;
            this.MobilePhone = mPhome;
            this.Email = email;
            this.payments = payts;
            this.customerType = cType;
        }

        public override string ToString()
        {
            string resPayments = "\n";
            foreach (var p in payments)
            {
                resPayments += p.ProductName + "->" + p.Price + "\n";
            }

            return String.Format("{0} {1} {2} EGN: {3}\nAddress: {4}\nMoibile phone: {5}\nEmail: {6}\nPayments: {7}\nCustomenr type: {8}\n",
                FirstName, MiddleName, LastName, EGN, PermanentAddress, MobilePhone, Email, resPayments, customerType);
        }

        public override bool Equals(object obj)
        {
            bool res = false;
            if (obj is Customer && obj != null)
            {
                Customer tempCustomer;
                tempCustomer = (Customer)obj;
                if (tempCustomer.EGN == this.EGN)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

            }
            else
            {
                res = false;
            }

            return res;
        }

        public static bool operator ==(Customer cust12, Customer cust2)
        {
            return cust12.Equals(cust12);
        }

        public static bool operator !=(Customer cust12, Customer cust2)
        {
            return !cust12.Equals(cust12);
        }

        public override int GetHashCode()
        {
            return EGN.GetHashCode() ^ FirstName.GetHashCode();//^LastName.GetHashCode();
        }

        public string getFullName()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }

        public object Clone()
        {
            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.EGN,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.payments,
                this.customerType);
        }

        public int CompareTo(object obj)
        {
                        
            Customer tempCustomer = obj as Customer;
            
            if (tempCustomer != null)
            {
                if (this.getFullName() == tempCustomer.getFullName())
                {
                   return 0;
                } else if (this.EGN > tempCustomer.EGN)
                {
                    return 1;
                } else
	            {
                    return -1;
	            }
            }
            else
            {
                throw new NotImplementedException();
            }

        }
    }
}
