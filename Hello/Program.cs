using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9 Mar 2020 - WriteLine with string
            //Console.WriteLine("Enter Your Name Here:");

            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Your cgpa Here:");

            //decimal cgpa = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Enter Your company name Here:");

            //string company = Console.ReadLine();


            //Console.WriteLine($"\nMy name is {name}.\nCurrently I\'m living in dhaka & working at a software company called {company}.\nMy university cgpa is {cgpa}");
            #endregion

            #region 9 Mar 2020 - List

            //Console.WriteLine("This program finds the greater number among your entered numbers.");
            //Console.WriteLine("How many numbers do you want to enter?");

            //decimal numbers = Convert.ToDecimal(Console.ReadLine());

            //List<decimal> enteredNumbers = new List<decimal>();

            //for (int i = 0; i < numbers; i++)
            //{
            //    enteredNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
            //}

            #endregion

            #region 9 Mar 2020 - Takes a number, adds them and shows
            //Console.WriteLine("Enter your first number here:");
            //string first = Console.ReadLine();
            //if (int.TryParse(first, out int firstNumber) != true)
            //{
            //    Console.WriteLine("Sorry! Not a valid number.");
            //}

            //Console.WriteLine("Enter your second number here:");
            //string second = Console.ReadLine();
            //if (int.TryParse(second, out int secondNumber) != true)
            //{
            //    Console.WriteLine("Sorry! Not a valid number.");
            //}

            //Console.WriteLine("Enter your third number here:");
            //string third = Console.ReadLine();
            //if (int.TryParse(third, out int thirdNumber) != true)
            //{
            //    Console.WriteLine("Sorry! Not a valid number.");
            //}

            //int result = firstNumber + secondNumber + thirdNumber;

            //Console.WriteLine($"\nSum:{result}");
            #endregion

            #region 9 Mar 2020 - Asks how many numbers to add. Takes them in and adds and shows

            //Console.WriteLine("How many numbers do you want to add?");
            //string a = Console.ReadLine();

            //int sum = 0;

            //if (int.TryParse(a, out int times))
            //{
            //    for (int i = 1; i <= times; i++)
            //    {
            //        Console.WriteLine($"Enter {i}th number:");

            //        string b = Console.ReadLine();

            //        if (int.TryParse(b, out int value))
            //        {
            //            sum = sum + value;
            //        }
            //    }

            //    Console.WriteLine($"\nSum:{sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry Sir.");
            //}

            #endregion

            #region 9 Mar 2020 - Asks how many numbers to take. Takes them then asks what to do with them? +,-,*,/. Then does them and shows

            Console.WriteLine("How many numbers do you want to operate?");
            string a = Console.ReadLine();

            Console.WriteLine("What to do with them? +,-,*,/:");
            string operation = Console.ReadLine();

            int sum = 0;

            if (int.TryParse(a, out int times))
            {
                for (int i = 1; i <= times; i++)
                {
                    Console.WriteLine($"Enter {i}th number:");

                    string b = Console.ReadLine();

                    if (int.TryParse(b, out int value))
                    {
                        if (operation == "+")
                        {
                            sum = sum + value;
                        }
                        else if (operation == "-")
                        {
                            sum = sum - value;
                        }
                            
                    }
                }

                Console.WriteLine($"\nSum:{sum}");
            }
            else
            {
                Console.WriteLine("Sorry Sir.");
            }

            #endregion


        }
    }
}


