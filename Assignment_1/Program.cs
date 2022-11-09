using System;
namespace Assignment_1
{
    public class Program {
        public static void Main(String[] args)
        {
            Question_1 obj1 = new Question_1();
            obj1.Question1();

            Question_2 obj2 = new Question_2();
            obj2.Question2();

            Question_3 obj3 = new Question_3();
            obj3.Enum_Country();

            Customer customer = new Customer("Damodhar","Saving");
            Customer c2 = new Customer("Abhishek", "Current");
            Customer c3 = new Customer();
            c3.OpenBankAccount("Sagar", "Saving");
      
            customer.CalculateSavingRate(10000,2);
            c2.CalculateSavingRate(20000, 3);
            c3.CalculateSavingRate(30000, 2);


        }
    }
    
}
