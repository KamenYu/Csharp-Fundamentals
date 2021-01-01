using System;

namespace gamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Name                   Price
             OutFall 4                     $39.99
             CS: OG                        $15.99
             Zplinter Zell	               $19.99
             Honored 2                     $59.99
             RoverWatch                    $29.99
             RoverWatch Origins Edition    $39.99 */

            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double spent = 0;
            bool isFound = true;
            double a = 0;
            double b = 0;

            while (command != "Game Time")
            {
                isFound = true;
                a = balance;
                b = spent;
                switch (command)
                {
                    case "OutFall 4":
                        balance -= 39.99;
                        spent += 39.99;
                       
                        break;
                    case "CS: OG":
                        balance -= 15.99;
                        spent += 15.99;
                       
                        break;
                    case "Zplinter Zell":
                        balance -= 19.99;
                        spent += 19.99;
                      
                        break;
                    case "Honored 2":
                        balance -= 59.99;
                        spent += 59.99;
                       
                        break;
                    case "RoverWatch":
                        balance -= 29.99;
                        spent += 29.99;
                        
                        break;
                    case "RoverWatch Origins Edition":
                        balance -= 39.99;
                        spent += 39.99;
                        
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        isFound = false;
                        break;
                }
                
                if (balance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    balance = a;
                    spent = b;
                }
                else if (balance >= 0 && isFound == true)   
                {
                    Console.WriteLine($"Bought {command}");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
        }
    }
}
