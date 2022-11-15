using System;

namespace Assignment_1
{
    internal class EmailValidation
    {
        public void Check_Email()
        {
            string email = "damodhar@gmail.com"; 
            int at=0;
            int dot=0;
            char[] E= email.ToCharArray();

            for (int i = 0; i < E.Length; i++)
            {
                if (E[i] == '@')
                {
                    at += 1;
                }else if (E[i]=='.'){
                    dot += 1;
                }
                
            }
            if((at>0 && at < 2) && dot> 0)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {

                Console.WriteLine("Email is Not Valid");
            }
            Console.WriteLine("");
        }
    }
}
