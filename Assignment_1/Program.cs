using System;
namespace Assignment_1
{
    public class Program {
        public static void Main(String[] args)
        {
            String_operation obj1 = new String_operation();
            obj1.Question1();

            EmailValidation obj2 = new EmailValidation();
            obj2.Check_Email();

            Practice_Enum obj3 = new Practice_Enum();
            obj3.Enum_Country();

            Customer customer = new Customer("Damodhar", "Saving");
            Customer c2 = new Customer("Abhishek", "Current");
            Customer c3 = new Customer();
            c3.OpenBankAccount("Sagar", "Saving");

            customer.CalculateSavingRate(10000, 2);
            c2.CalculateSavingRate(20000, 3);
            c3.CalculateSavingRate(30000, 2);
        }
    }    
}
