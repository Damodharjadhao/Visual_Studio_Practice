using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Assignment_2
{
    internal class Question_4
    {
        public void ReadFile()
        {
        string filepath = @"C:\Users\Damodhar.Jadhao\Desktop\C#_Practice\CS_Assignment_2\text.txt";

            Console.WriteLine("Reading File using File.ReadAllText()");

            // To read the entire file at once
            if (File.Exists(filepath))
            {
                // Read all the content in one string
                // and display the string
                string str = File.ReadAllText(filepath);
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }          
    }
}
