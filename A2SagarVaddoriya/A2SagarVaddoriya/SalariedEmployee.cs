using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SagarVaddoriya
{
    class SalariedEmployee : Employee
    {

        private double _weeklySalary;


        public SalariedEmployee( EmployeeType empType, string empName, double weeklySalary) : base( empType, empName)
        {
            WeeklySalary = weeklySalary;
        }


        // property
        public double WeeklySalary
        {
            get { return _weeklySalary; }
            set
            {
                if (value < 0)
                    throw new Exception("Weekly salary must be > 0");
                else
                    _weeklySalary = value;
            }
        }


        // calculate earnings; override abstract method Earnings in Employee
        public override double GrossEarnings()
        {
            return WeeklySalary;
        }

    }
}
