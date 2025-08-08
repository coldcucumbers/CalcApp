using System;
using System.IO;
bool keepRunning = true;
    while (keepRunning)
    {
        Console.WriteLine("What would you like to do today for two numbers");
        Console.WriteLine("(1) Add");
        Console.WriteLine("(2) Subtract");
        Console.WriteLine("(3) Multiply");
        Console.WriteLine("(4) Divide");
        int numResult = int.Parse(Console.ReadLine() ?? "0");


        Console.WriteLine("Enter your first value: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Enter your second value: ");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        if (numResult == 1)
        {
            int sum = num1 + num2;
            if (sum % 2 == 0)
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sum);
            }
            else
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sum);
            }
            Console.ResetColor(); // always reset at the end
            File.AppendAllText("calculator-logs.txt", $"The user added {num1} and {num2} and got an output of {sum}. \n");
        }
        else if (numResult == 2)
        {
            int sum = num1 - num2;
            if (sum % 2 == 0)
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sum);

            }
            else
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sum);
            }
            Console.ResetColor(); // always reset at the end
            File.AppendAllText("calculator-logs.txt", $"The user subtracted {num1} and {num2} and got an output of {sum}. \n");
        }
        else if (numResult == 3)
        {
            int sum = num1 * num2;
            if (sum % 2 == 0)
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sum);


            }
            else
            {
                Console.Write("Your sum is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sum);
            }
            Console.ResetColor(); // always reset at the end
            File.AppendAllText("calculator-logs.txt", $"The user multiplied {num1} and {num2} and got an output of {sum}. \n");
        }
        else if (numResult == 4)
        {
            double sum = (double)num1 / num2;
            // check if it's a whole number
            if (sum % 1 == 0)
            {
                // whole number checks if even or odd
                if (sum % 2 == 0)
                {
                    Console.Write("Your sum is: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sum);

                }
                else
                {
                    Console.Write("Your sum is: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(sum);
                }
            }
            else
            {
                // print with no color
                Console.Write("Your sum is: ");
                Console.WriteLine(sum.ToString("F3")); // limit to 3 decimals .To 
            }
            Console.ResetColor(); // always reset at the end
            File.AppendAllText("calculator-logs.txt", $"The user divided {num1} and {num2} and got an output of {sum}. \n");
        }
        Console.WriteLine("Do you want to do another calculation? (y/n)");
        string answer = Console.ReadLine();
        if (answer != "y")
        {
            keepRunning = false;
        }
    }
