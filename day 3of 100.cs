using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is the calculator you used during Jamb");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Division");
        Console.WriteLine("4. Multiplication");
        Console.WriteLine("exit");
        // Selection
        string menuSelection;
        do
        {
            string readResult = Console.ReadLine(); 
            if (readResult != null)
            {
                 menuSelection = readResult.ToLower();
         

                switch (menuSelection)
                {
                    case "1":
                        Console.WriteLine("Enter two numbers to be added");
                        double additionResult = 0;

                        Console.Write("Enter the first number: ");
                        if (double.TryParse(Console.ReadLine(), out double number1))
                        {
                            Console.Write("Enter the second number: ");
                            if (double.TryParse(Console.ReadLine(), out double number2))
                            {
                                additionResult = number1 + number2;
                                Console.WriteLine($"{number1} + {number2} = {additionResult}");
                                Console.WriteLine("select the next option or exit");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for the second number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for the first number.");
                        }
                        break;
                    //subtraction
                    case "2":
                        Console.WriteLine("Enter two numbers to be subtracted");
                        double subtractionResult = 0;

                        Console.Write("Enter the first number: ");
                        if (double.TryParse(Console.ReadLine(), out double number1sub))
                        {
                            Console.Write("Enter the second number: ");
                            if (double.TryParse(Console.ReadLine(), out double number2sub))
                            {
                                subtractionResult = number1sub - number2sub;
                                Console.WriteLine($"{number1sub} - {number2sub} = {subtractionResult}");
                                Console.WriteLine("select the next option or exit");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for the second number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for the first number.");
                        }
                        break;
                    //division
                    case "3":
                        Console.WriteLine("Enter two numbers to be divided");
                        double divisionResult = 0;

                        Console.Write("Enter the first number: ");
                        if (double.TryParse(Console.ReadLine(), out double number1div))
                        {
                            Console.Write("Enter the second number: ");
                            if (double.TryParse(Console.ReadLine(), out double number2div))
                            {
                                divisionResult = number1div / number2div;
                                Console.WriteLine($"{number1div} / {number2div} = {divisionResult}");
                                Console.WriteLine("select the next option or exit");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for the second number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for the first number.");
                        }
                        break;
                    // mutiplication
                    case "4":
                        Console.WriteLine("Enter two numbers to be multipied");
                        double multiplicationResult = 0;

                        Console.Write("Enter the first number: ");
                        if (double.TryParse(Console.ReadLine(), out double number1multi))
                        {
                            Console.Write("Enter the second number: ");
                            if (double.TryParse(Console.ReadLine(), out double number2multi))
                            {
                                multiplicationResult = number1multi * number2multi;
                                Console.WriteLine($"{number1multi} * {number2multi} = {multiplicationResult}");
                                Console.WriteLine("select the next option or exit");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for the second number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for the first number.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine(" you are exiting");
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;

                      
                }
            }
            // i dont understand why when the else codeblock is removed the debugger deem menuselction for while statement as ]unassigned
            else
            {
                // Handle null input
                menuSelection = "";
            }

        } while (menuSelection != "exit");
    }
}
