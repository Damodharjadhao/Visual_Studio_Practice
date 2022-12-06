using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Assignment_2
{
    internal class Linq_practice
    {
        double id;
        string? name;
        string? education;

        public double Id { get { return id; } set { id = value; } }
        public string Name{ get {return name;} set { name = value; } }
        public string Education{ get {return education;} set { education = value; } }


        public override string ToString()
        {
            return Id + " " + Name + " " +
                   Education;
        }
    }

    class Student:Linq_practice
    {

        public void showStudent()
        {
            List<Linq_practice> students = new List<Linq_practice>
            {
                new Linq_practice{Id=1,Name="Abhishek",Education="CSE" },
                new Linq_practice{Id=3,Name="Damodhar",Education="B.Tech" },
                new Linq_practice{Id=3,Name="Sagar",Education="B.Com" }
            };

            IEnumerable<Linq_practice> stdList = from std in students select std;

            foreach (Linq_practice s in stdList)
            {
                Console.WriteLine(s.ToString());
            }

        }
    }
}
