using System;

namespace ManyUtility
{

    class Program
    {
        static void Menu()
        {
            int choice = 0;

            do
            {
                // Display different utility choices to user
                Console.WriteLine("Hello, and Welcome to ManyUtility!!");
                Console.WriteLine("\nPlease select which utility you would like to use");
                Console.WriteLine("1. - Calculator \n2. - Random Number Generator \n3. - Unknown \n0.- Quit");

                // Get user input
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    //Open the calculator function
                    case 1:
                        Calculator.calcMenu();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;


                    default:
                        break;
                }
            } while (choice != 0);

        }


        static void Main(string[] args)
        {
            Menu();
        }
    }
}
