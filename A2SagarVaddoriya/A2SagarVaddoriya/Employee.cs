using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SagarVaddoriya
{
    enum EmployeeType
    {
         HourlyEmployee = 1, CommissionEmployee = 2, WeeklyEmployee = 3

    }
    abstract class Employee
    {
       
        private EmployeeType _empType;
        private string _empName;

        public Employee(EmployeeType empType, string empName)
        {

            EmpType = empType;
            EmpName = empName;
        }
        public EmployeeType EmpType
        {
            get { return _empType; }
            private set { _empType = value; }
        }
        public string EmpName
        {
            get { return _empName; }
            private set {
                _empName = value; }
        }

        public abstract double GrossEarnings();
       

    }
    
   
}
