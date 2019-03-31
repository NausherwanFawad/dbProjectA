using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Advisor
    {
        private int id;
        private int salary;
        private int Designation;


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public int Designation1
        {
            get
            {
                return Designation;
            }

            set
            {
                Designation = value;
            }
        }
    }
}
