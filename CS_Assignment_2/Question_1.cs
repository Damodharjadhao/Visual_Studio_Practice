using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CS_Assignment_2
{
    internal class ValidateEmail
    {
        // Write a C# program to validate an Email ID using regex        
        public bool CheckEmail(string email)
        {

            Regex emailregex = new(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
            Console.WriteLine($"The email is {email}");

            bool isValidEmail = emailregex.IsMatch(email);

            if (!isValidEmail)
            {
                Console.WriteLine($"The email is invalid");
            }
            else
            {
                Console.WriteLine($"The email is valid");
            }
            Console.ReadLine();
            return emailregex.IsMatch(email);
        }
    }    
}
