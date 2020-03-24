using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2SagarVaddoriya
{
    public partial class Form1 : Form
    {
        Employee emp;
        List<Employee> list = new List<Employee>();
        List<double> wagelist = new List<double>();
       

        public Form1()
        {
            InitializeComponent();
            rdoHourly.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdoWeekly.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdoCommission.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            this.LocationChanged += new System.EventHandler(this.SystemEvents_DisplaySettingsChanged);


        }
        void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == rdoHourly)
                {
                    lblHourWage.Visible = true;
                    txtHourWage.Visible = true;
                    lblHourWork.Text = "Houres Worked: ";
                    lblHourWage.Text = "Hourly Rate: ";
                    txtGrossEarning.Text = "";
                    txtHourWage.Text = "";
                    txtHourWork.Text = "";
                    txtLessTax.Text = "";
                    txtName.Text = "";
                    txtNetEarning.Text = "";
                }
                else if (((RadioButton)sender) == rdoCommission)
                {
                    lblHourWage.Visible = true;
                    txtHourWage.Visible = true;
                    
                    lblHourWork.Text = "Gross Sales: ";
                    lblHourWage.Text = "Commission Rate: ";
                    txtGrossEarning.Text = "";
                    txtHourWage.Text = "";
                    txtHourWork.Text = "";
                    txtLessTax.Text = "";
                    txtName.Text = "";
                    txtNetEarning.Text = "";
                }
                else
                {
                    lblHourWork.Text = "Weekly Salary: ";
                    lblHourWage.Visible = false;
                    txtHourWage.Visible = false;
                    txtGrossEarning.Text = "";
                    txtHourWage.Text = "";
                    txtHourWork.Text = "";
                    txtLessTax.Text = "";
                    txtName.Text = "";
                    txtNetEarning.Text = "";
                }
            }
        }

      
        private void btnCalculate_Click(object sender, EventArgs e)
        {


            bool flag = true;
             string name = txtName.Text;
            string label1 = txtHourWork.Text;
            string label2 = txtHourWage.Text;
           
            if(name.Equals(""))
            {
                MessageBox.Show(" name must not be blank");
                flag = false;
            }
         
           
            else
            {
                for (int i = 0; i < cmbEmployee.Items.Count; i++)
                {
                    string value = cmbEmployee.GetItemText(cmbEmployee.Items[i]);
                    if (value.Equals(name))
                    {
                        MessageBox.Show(" name must be unique");
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            
            
            if(flag)
            {
                if (rdoHourly.Checked)
                {


                    if (txtHourWork.Text.Equals("") || txtHourWage.Text.Equals(""))
                    {
                        MessageBox.Show("hour or wage can not be empty");
                        flag = false;
                    }
                    else
                    {
                        int hour = int.Parse(txtHourWork.Text);


                        double wage = double.Parse(txtHourWage.Text);

                        if (hour < 0 || hour > 80)
                        {
                            MessageBox.Show("hour can not be nagative or greater than 80");
                            flag = false;
                        }
                        else if (wage < 0)
                        {
                            MessageBox.Show("wage can not be nagative");
                            flag = false;
                        }
                        else
                        {
                            emp = new HourlyEmployee(EmployeeType.HourlyEmployee, name, hour, wage);

                            double earning = emp.GrossEarnings();
                            txtGrossEarning.Text = earning.ToString();
                            double tax = earning * 20 / 100;
                            txtLessTax.Text = tax.ToString();
                            double netEarning = earning - tax;
                            txtNetEarning.Text = netEarning.ToString();
                            cmbEmployee.Items.Add(name);
                            list.Add(emp);
                            wagelist.Add(hour);
                        }

                    }                      
                }
                else if (rdoCommission.Checked)
                {

                    if (txtHourWork.Text.Equals("") || txtHourWage.Text.Equals(""))
                    {
                        MessageBox.Show("gross sales or commission rate can not be empty");
                        flag = false;
                    }
                    else
                    {

                        double grosssales = double.Parse(txtHourWork.Text);
                        double commission = double.Parse(txtHourWage.Text);
                        if (grosssales < 0)
                        {
                            MessageBox.Show("gross sales can not be nagative");
                            flag = false;
                        }
                        else if (commission < 0)
                        {
                            MessageBox.Show("commission rate can not be nagative");
                            flag = false;
                        }
                        else
                        {
                            emp = new CommissionEmployee(EmployeeType.CommissionEmployee, name, grosssales, commission);
                            double earning = emp.GrossEarnings();
                            txtGrossEarning.Text = earning.ToString();
                            double tax = earning * 20 / 100;
                            txtLessTax.Text = tax.ToString();
                            double netEarning = earning - tax;
                            txtNetEarning.Text = netEarning.ToString();
                            cmbEmployee.Items.Add(name);
                            list.Add(emp);
                            wagelist.Add(grosssales);
                        }
                    }
                    
                }
                else
                {
                    if (txtHourWork.Text.Equals(""))
                    {
                        MessageBox.Show("weekly salary can not be empty");
                        flag = false;
                    }
                    else
                    {
                        double salary = double.Parse(txtHourWork.Text);
                        if (salary < 0)
                        {
                            MessageBox.Show("salary can not be nagative");
                            flag = false;
                        }
                        else
                        {
                            emp = new SalariedEmployee(EmployeeType.WeeklyEmployee, name, salary);
                            double earning = emp.GrossEarnings();
                            txtGrossEarning.Text = earning.ToString();
                            double tax = earning * 20 / 100;
                            txtLessTax.Text = tax.ToString();
                            double netEarning = earning - tax;
                            txtNetEarning.Text = netEarning.ToString();
                            cmbEmployee.Items.Add(name);
                            list.Add(emp);
                            wagelist.Add(salary);
                        }

                    }
                }
            }
            
               
                
                
            
           

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = list.Count;
            for(int i = 0; i<length;i++)
            {
                if (cmbEmployee.SelectedIndex == i)
                {
                    
                    
                        txtName.Text = list[i].EmpName;
                        txtGrossEarning.Text = list[i].GrossEarnings().ToString();
                        
                         
                    double wage = 0;
                    int type = (int)list[i].EmpType;
                    Console.WriteLine(type);
                    if (type == 1)
                    {
                        // txtHourWage.Text = "hourly";
                        rdoHourly.Checked = true;
                        rdoCommission.Checked = false;
                        rdoWeekly.Checked = false;
                        txtHourWork.Text = wagelist[i].ToString();
                        wage = list[i].GrossEarnings() / wagelist[i];
                        txtHourWage.Text = wage.ToString();

                    }
                    else if (type == 2)
                    {
                        // txtHourWage.Text = "commission";
                        rdoHourly.Checked = false;
                        rdoCommission.Checked = true;
                        rdoWeekly.Checked = false;
                        txtHourWork.Text = wagelist[i].ToString();
                        wage = (list[i].GrossEarnings() * 100) / wagelist[i];
                        txtHourWage.Text = wage.ToString();
                    }

                    else
                    {
                        rdoHourly.Checked = false;
                        rdoCommission.Checked = false;
                        rdoWeekly.Checked = true;
                        txtHourWork.Text = wagelist[i].ToString();
                    }
                    double tax = list[i].GrossEarnings() * 20 / 100;
                        double sal = list[i].GrossEarnings() - tax;
                        txtLessTax.Text = tax.ToString();
                        txtNetEarning.Text = sal.ToString();
                    
                   
                        txtName.Text = list[i].EmpName;
                        txtGrossEarning.Text = list[i].GrossEarnings().ToString();
                        
                        
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for(int i= 0; i<cmbEmployee.Items.Count;i++)
            {
                if(txtName.Text.Equals(list[i].EmpName))
                {
                    list.RemoveAt(i);
                    wagelist.RemoveAt(i);
                    txtGrossEarning.Text = "";
                    txtHourWage.Text = "";
                    txtHourWork.Text = "";
                    txtLessTax.Text = "";
                    txtName.Text = "";
                    txtNetEarning.Text = "";
                    cmbEmployee.Items.RemoveAt(i);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
    }
}
