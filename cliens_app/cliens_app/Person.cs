using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliens_app
{
    public class Person
    {
        public string lastName { get; set; }
        public string firstName { get; set; }

        public string fullName { get; set; }

        public void setFullName()
        {
            this.fullName = this.lastName +" "+ this.firstName;
        }

    }
}
