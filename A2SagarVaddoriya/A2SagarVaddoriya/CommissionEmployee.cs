using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SagarVaddoriya
{
    class CommissionEmployee : Employee
    {
        private double _grossSales;      
        private double _commissionRate;
        public CommissionEmployee(EmployeeType empType, string empName, double grossSales, double commissionRate) : base(empType, empName)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }


     
        public double GrossSales
        {
            get { return _grossSales; }

            set
            {
                if (value < 0)
                    throw new Exception("Gross sales cannot be less than 0");
                else
                    _grossSales = value;
            }
        }

        public double CommissionRate
        {
            get { return _commissionRate; }

            set
            {
               
                    _commissionRate = value;
            }
        }


        // calculate earnings; override abstract method Earnings in Employee
        public override double GrossEarnings()
        {
            return GrossSales * CommissionRate/100;
        }

    }
}
