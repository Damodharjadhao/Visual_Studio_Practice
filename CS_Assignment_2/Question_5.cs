using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{
    internal class Question_5
    { 
        int emp_id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;

        public void ShowEmpData()
        {
            List<Question_5> employee = new List<Question_5>()
    {
        new Question_5{emp_id = 101, Emp_Name = "Amit",
                 Emp_Salary = 50000,Emp_Department = "XYZ"},
        new Question_5{emp_id = 102, Emp_Name = "Poonam",
                 Emp_Salary = 65000,Emp_Department = "ABC"},
        new Question_5{emp_id = 103, Emp_Name = "Priya",
                 Emp_Salary = 45000,Emp_Department = "ABC"},
        new Question_5{emp_id = 104, Emp_Name = "Sita",
                 Emp_Salary = 20000,Emp_Department = "XYZ"},
        new Question_5{emp_id = 105, Emp_Name = "kiran",
                 Emp_Salary = 70000,Emp_Department = "ABC"},
        new Question_5{emp_id = 106, Emp_Name = "Sohan",
                 Emp_Salary = 40000,Emp_Department = "XYZ"},
    };

            var result_set = employee.Where(emp => emp.Emp_Department == "XYZ").OrderByDescending(
                                         sal => sal.Emp_Salary);

            foreach (Question_5 emp in result_set)
            {
                Console.WriteLine(emp.emp_id + " " +
                                  emp.Emp_Name + " " +
                                  emp.Emp_Salary + " " +
                                  emp.Emp_Department);
            }
        }
    }
}
