using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SagarVaddoriya
{
    class HourlyEmployee : Employee
    {
        private int _hours;
        private double _wage;


        public HourlyEmployee(EmployeeType empType, string empName, int hours, double wage) : base( empType, empName)
        {
            Hours = hours;
            Wage = wage;
        }
        public int Hours
        {
            get { return _hours; }
            set
            {
                
              _hours = value;
            }
        }

        public double Wage
        {
            get { return _wage; }
            set
            {
                // validate
                _wage = value;
            }
        }

        public override double GrossEarnings()
        {
            if (Hours <= 40)
                return Hours * Wage;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5);
        }
       

    }
    
}