using System;
namespace Assignment_1
{
    public enum country
    {
        India, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND
    }
    internal class Practice_Enum
    {     
       public void Enum_Country()
       {

            Console.WriteLine("Enum Country");
            int x = (int)country.AUSTRALIA;
            Console.WriteLine(x);
            int y = (int)country.JAPAN;
            Console.WriteLine(y);
       }   
    }
}
