using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Should you buy or rent a home?, the following questions should help you decide.");
            Console.WriteLine("Please answer yes or no");
            Console.WriteLine("Do you plan to be in this home for 5 or more years?");
            string years = Convert.ToString(Console.ReadLine());

            if (years == "yes")
            {
                Console.WriteLine("Do you have an emergency fund?");
                string emergencyFund = Convert.ToString(Console.ReadLine());

                if (emergencyFund == "yes")
                {
                    Console.WriteLine("By the time of purchase, will you have enough cash saved for a 20% down payment plus fees?");
                    string downPayment = Convert.ToString(Console.ReadLine());

                    if (downPayment == "yes")
                    {
                        Console.WriteLine("Will buying a home wipe out all your savings?");
                        string wipeSavings = Convert.ToString(Console.ReadLine());

                        if (wipeSavings == "no")
                        {
                            Console.WriteLine("You should buy a house");
                        }
                        else
                        {
                            Console.WriteLine("You should rent");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You should rent");
                    }

                }
                else
                {
                    Console.WriteLine("You should rent");
                }

            }
            else
            {
                Console.WriteLine("You should rent");
            }
            
        Console.ReadKey();
            
        }
    }
}
