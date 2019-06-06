using System;

namespace ManyUtility
{
    public class Calculator
    {
        static void calcMenu()
        {
            int choice = 0;
            var firstNum;
            var secNum;
            string mathOperator;

            //Intro to calculator 
            Console.WriteLine("Welcome to the Calculator");

            do
            {
                //Ask what they would like to do.
                Console.WriteLine("\n\nWhat would you like to do? (1. - Add, 2. - Subtract, 3. - Multiply 4. - Divide 0. - Exit to Main Menu)");
                choice = Convert.ToInt16(Console.ReadLine());

                // Get first number
                Console.WriteLine("Please enter the first number:");
                firstNum = Console.ReadLine();

                //Get second number
                Console.WriteLine("Please enter the second number:");
                secNum = Console.ReadLine();


                //Select proper function
                if (choice == 1)
                {
                    mathOperator = "+";
                    result = add(firstNum, secNum);

                }
                else if (choice == 2)
                {
                    mathOperator = "-";
                    result = subtract(firstNum, secNum);
                }
                else if (choice == 3)
                {
                    mathOperator = "*";
                    result = mutliply(firstNum, secNum);
                }
                else if (choice == 4)
                {
                    mathOperator = "//";
                    result = divide(firstNum, secNum);
                }

                Console.WriteLine("{firstNum} {mathOperator} {secNum} = {result)");
            } while (choice != 0);
        }


        //Add two integers
        public int add(int x, int y)
        {
            return x + y;
        }


        //Add two doubles
        public double add(double x, double y)
        {
            return x + y;
        }


        //Subtract
        public var subtract(var x, var y)
        {
            return x - y;
        }


        //Multiply
        public var multiply(var x, var y)
        {
            return x * y;
        }

        //Divide
        public var divide(var x, var y)
        {
            return x / y;
        }
    }

}
