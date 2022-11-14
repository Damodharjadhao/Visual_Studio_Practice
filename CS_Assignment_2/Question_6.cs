using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{
    class Generic<Type>
    {
        private Type val;

        public Type Val
            {
            get { return val; }
            set { val = value; }
            }

    }
    internal class Question_6
    {
        public void Show()
        {
            Generic<string> abc = new Generic<string>();
            abc.Val = "String Type Data";

            Generic<int> a = new Generic<int>();
            a.Val = 10;

            Console.WriteLine(abc.Val);
            Console.WriteLine(a.Val);
        }
        
    }
}
