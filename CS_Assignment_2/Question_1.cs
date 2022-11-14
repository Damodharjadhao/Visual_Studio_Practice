using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CS_Assignment_2
{
    internal class Question_1
    {
        // Write a C# program to validate an Email ID using regex        
        public bool CheckEmail(string email)
        {

            Regex emailregex = new Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", RegexOptions.IgnoreCase);
            return emailregex.IsMatch(email);
        }
    }    
}
