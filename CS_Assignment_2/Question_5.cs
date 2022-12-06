using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{

    class Employee:LinqOperation
    {
        int emp_id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;

        public int EmpID { get { return emp_id; } set { emp_id = value; } }
        public string EmpName { get { return Emp_Name; } set { Emp_Name = value; } }

        public int EmpSalary { get { return Emp_Salary; } set { Emp_Salary = value; } }

        public string EmpDept { get { return Emp_Department; } set { Emp_Department = value; } }

    }

    internal class LinqOperation
    {
        public void ShowEmpData()
        {
            List<Employee> employee = new List<Employee>()
        {
        new Employee{EmpID = 101, EmpName = "Amit",
                 EmpSalary = 50000,EmpDept = "XYZ"},
        new Employee{EmpID = 102, EmpName = "Poonam",
                 EmpSalary = 65000,EmpDept = "ABC"},
        new Employee{EmpID = 103, EmpName = "Priya",
                 EmpSalary = 45000,EmpDept = "ABC"},
        new Employee{EmpID = 104, EmpName = "Sita",
                 EmpSalary = 20000,EmpDept = "XYZ"},
        new Employee{EmpID = 105, EmpName = "kiran",
                 EmpSalary = 70000,EmpDept = "ABC"},
        new Employee{EmpID = 106, EmpName = "Sohan",
                 EmpSalary = 40000,EmpDept = "XYZ"},
        };

            var result_set = employee.Where(emp => emp.EmpDept == "XYZ").OrderByDescending(
                                         sal => sal.EmpSalary);

            foreach (Employee emp in result_set)
            {
                Console.WriteLine(emp.EmpID + " " +
                                  emp.EmpName + " " +
                                  emp.EmpSalary + " " +
                                  emp.EmpDept);
            }
        }
    }
}
