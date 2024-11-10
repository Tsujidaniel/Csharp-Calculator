// See https://aka.ms/new-console-template for more information
using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double numb1 = 0;
                double numb2 = 0;
                double result = 0;
                string operator1 = "";
                 

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");
                Console.WriteLine("Please inform your first number");
                numb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------------");
                Console.WriteLine("Please inform your second number");
                numb2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------------");
                Console.WriteLine("Please inform the operator: ");
                Console.WriteLine("+ for addtion ");
                Console.WriteLine("- for substraction ");
                Console.WriteLine("* for multiplication ");
                Console.WriteLine("/ for division ");
                operator1 = Console.ReadLine();

                switch (operator1)
                {
                    
                    case "+":
                        result = numb1 + numb2;
                        Console.WriteLine("The result is: "+ result);
                    break;
                    case "-":
                        result = numb1 - numb2;
                        Console.WriteLine("The result is: "+ result);
                    break;
                    case "*":
                        result = numb1 * numb2;
                        Console.WriteLine("The result is: "+ result);
                    break;
                    case "/":
                        result = numb1 / numb2;
                        Console.WriteLine("The result is: "+ result);
                    break;
                    default:
                        Console.WriteLine("Operador "+operator1+ " não existe"); 
                    break;
                }

                Console.WriteLine("Would you like do more calculation? Y = Yes or N = No");
            }while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Bye!");
        }
    }    
}
