using System; //created by JEHAN L. HADJISAID of PUP COE 1-2
using System.Diagnostics;
using System.Windows.Forms;

namespace BasicCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            string operation;
            string status;
            float answer;

            while (true)
            {
                Console.Write("\t\t\t>>CALCULATOR by Jehan<<\n\nEnter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose an operation[+,-,*,/]: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        Console.WriteLine("\nInvalid Operation.");
                        break;
                }

                Console.WriteLine($"\n{num1} {operation} {num2} = {answer}");
                Console.Write("\n\nDo You Want To Try Again [Y/N]? ");
                status = Console.ReadLine();
                if ((status == "N") || (status == "n"))
                {
                    Console.Write("Press enter to exit.");
                    Console.ReadKey();
                    break;
                }
                Console.Clear();
            }
        }
    }
}