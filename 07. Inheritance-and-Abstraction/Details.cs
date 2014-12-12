using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Details
    {
        private string det;

        public string Detail
        {
            get
            {
                return det;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Details can be empty");
                }
                this.det = value;
            }
        }

        public Details(string detail)
        {
            this.Detail = detail;
        }
    }
}
