namespace CS_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            ValidateEmail object1 =new ValidateEmail();
            Console.WriteLine(object1.CheckEmail("damu@gmail.com"));
            //2
            Exception_Handle object2 = new Exception_Handle();
            object2.DivideByZeroExample(0);
            //3
            Student object3 = new Student();
            object3.showStudent();
            //4
            File_operation object4 = new File_operation();
            object4.ReadFile();
            //5 
            Employee object5 = new Employee();
            object5.ShowEmpData();
            //6
            Generic_practice object6 = new Generic_practice();
            object6.Show();

        }
    }
}