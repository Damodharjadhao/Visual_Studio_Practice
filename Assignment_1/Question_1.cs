using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Question_1
    {
        public void Question1()
        {
            string str1 = "Hello ";
            string str2 = "Welcome to visual Studio";
            Console.WriteLine("str1 = "+str1);
            Console.WriteLine("str2 =" + str2);
            //Concat String
            Console.WriteLine(string.Concat("String Concating : ",str1, str2));

            //Compare String
            Console.WriteLine("Compare str1 and str2 " + string.Compare(str1,str2));

            //Substring
            string str3 = str2.Substring(10);
            Console.WriteLine("Substring of Str2 : "+ str3);

            // Reverse String
            char[] str5 = str1.ToCharArray();
            Array.Reverse(str5);
            Console.WriteLine("Reverse str1 : "+ new string(str5));

        }
    }

}
