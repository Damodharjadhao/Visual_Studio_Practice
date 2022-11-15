using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{
    internal class Exception_Handle
    {
        public void NullReferenceExample(string str)
        {
            try
            {
                Console.WriteLine(str.Substring(2));
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DivideByZeroExample(int a)
        {
            try
            {
                int b = 100 / a;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
