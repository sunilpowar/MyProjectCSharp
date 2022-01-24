namespace MyProject.Example
{
    internal class ExampleEightA
    {
        static void Main()
        {
            int num1, num2;
            //Accepting values from users
            Console.WriteLine("Enter First Number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)   //Comparison Operator
            {
                Console.WriteLine("\n\nNum1 is greater than Num2\t\t");
            }
            else
            {
                Console.WriteLine("\n\nNum2 is greater than Num1\t\t");
            }
            Console.ReadKey();

        }
    }
}
