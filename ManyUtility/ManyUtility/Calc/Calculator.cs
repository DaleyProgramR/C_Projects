using System;

namespace ManyUtility
{
    public static class Calculator
    {
        public static void calcMenu()
        {
            int choice = 0;
            double firstNum=0;
            int num1;
            double secNum=0;
            int[] availChoice = {0, 1, 2, 3, 4};
            double result = 0;

            string mathOperator = "";

            //Intro to calculator 
            Console.WriteLine("Welcome to the Calculator");

            do
            {
                //Ask what they would like to do.
                //do
                //{
                Console.WriteLine("\n\nWhat would you like to do? (1. - Add, 2. - Subtract, 3. - Multiply 4. - Divide 0. - Exit to Main Menu)");
                choice = Convert.ToInt16(Console.ReadLine());

                //} while (Array.Exists(availChoice, element => element != choice));


                //Select proper function
                if (choice != 0)
                {
                    // Get first number
                    Console.WriteLine("Please enter the first number:");
                    firstNum = Convert.ToDouble(Console.ReadLine());


                    //Get second number
                    Console.WriteLine("Please enter the second number:");
                    secNum = Convert.ToDouble(Console.ReadLine());
                }

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
                    result = multiply(firstNum, secNum);
                }
                else if (choice == 4)
                {
                    mathOperator = "//";
                    result = divide(firstNum, secNum);
                }
                else
                {
                    //Clear console
                    Console.Clear();
                    break;
                }

                Console.WriteLine("{0} {1} {2} = {3}", firstNum, mathOperator, secNum, result);
            } while (choice != 0);
        }




        //Add two doubles
        public static double add(double x, double y)
        {
            return x + y;
        }


        //Subtract
        public static double subtract(double x, double y)
        {
            return x - y;
        }


        //Multiply
        public static double multiply(double x, double y)
        {
            return x * y;
        }

        //Divide
        public static double divide(double x, double y)
        {
            return x / y;
        }
    }

}
