using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{
    internal class Question_3
    {
        Double id;
        string? Name;
        string? Education;

        public override string ToString()
        {
            return id + " " + Name + " " +
                   Education;
        }

        public void showStudent()
        {
            List<Question_3> students = new List<Question_3>
            {
                new Question_3{id=1,Name="Abhishek",Education="CSE" },
                new Question_3{id=3,Name="Damodhar",Education="B.Tech" },
                new Question_3{id=3,Name="Sagar",Education="B.Com" }
            };

            IEnumerable<Question_3> stdList = from std in students select std;

            foreach(Question_3 s in stdList)
            {
                Console.WriteLine(s.ToString());
            }

        }
    }
}
