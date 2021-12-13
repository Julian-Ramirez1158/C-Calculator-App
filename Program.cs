using System;

namespace Calculator_App
{
    class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("********Caculator App********");
            Console.WriteLine("        1. Addition");
            Console.WriteLine("        2. Subtraction");
            Console.WriteLine("        3. Multiplication");
            Console.WriteLine("        4. Division");
            Console.WriteLine("        5. Exit");
            Console.WriteLine("*****************************");
        }

        static void Main(string[] args)
        {

            int option = 0;
            int total = 0;
            int difference = 0;
            int product = 0;
            double quotient = 0;
            int addition1 = 0;
            int addition2 = 0;
            int subtraction1 = 0;
            int subtraction2 = 0;
            int multiplication1 = 0;
            int multiplication2 = 0;
            double division1 = 0;
            double division2 = 0;

            do
            {

                Console.WriteLine("\n");

                ShowMenu();

                Console.WriteLine("\n");

                Console.WriteLine("Welcome to my calculator app! Please enter an option, then press ENTER.");

                option = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (option) {

                    case 1:
                        Console.WriteLine("What two numbers would you like to add? Type the integers one at a time and press ENTER for each.");
                        addition1 = Convert.ToInt32(Console.ReadLine());
                        addition2 = Convert.ToInt32(Console.ReadLine());
                        total = addition1 + addition2;
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your total is {total}.");
                        break;

                    case 2:
                        Console.WriteLine("What two numbers would you like to subtract? Type the integers one at a time and press ENTER for each.");
                        subtraction1 = Convert.ToInt32(Console.ReadLine());
                        subtraction2 = Convert.ToInt32(Console.ReadLine());
                        difference = subtraction1 - subtraction2;
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your total is {difference}.");
                        break;

                    case 3:
                        Console.WriteLine("What two numbers would you like to multiply? Type the integers one at a time and press ENTER for each.");
                        multiplication1 = Convert.ToInt32(Console.ReadLine());
                        multiplication2 = Convert.ToInt32(Console.ReadLine());
                        product = multiplication1 * multiplication2;
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your total is {product}.");
                        break;

                    case 4:
                        Console.WriteLine("What two numbers would you like to divide? Type the integers one at a time and press ENTER for each.");
                        division1 = Convert.ToDouble(Console.ReadLine());
                        division2 = Convert.ToDouble(Console.ReadLine());
                        quotient = division1 / division2;
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your total is {quotient}.");
                        break;

                    case 5:
                        Console.WriteLine("Thank you for using my calculator app! Have a great day!");
                        break;
                }


            } while (option != 5);





            Console.Read();
        }
    }
}
