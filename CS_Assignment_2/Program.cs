namespace CS_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Question_1 object1=new Question_1();
            Console.WriteLine(object1.CheckEmail("damu@gmail.com"));
            //2
            Question_2 object2=new Question_2();
            object2.DivideByZeroExample(0);
            //3
            Question_3 object3 = new Question_3();
            object3.showStudent();
            //4
            Question_4 object4 = new Question_4();
            object4.ReadFile();
            //5
            Question_5 object5 = new Question_5();
            object5.ShowEmpData();
            //6
            Question_6 object6 = new Question_6();
            object6.Show();

        }
    }
}