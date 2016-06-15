using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static bool GetChoice()
        {
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Should you buy or rent a home?, the following questions should help you decide.");
            Console.WriteLine("Please answer yes or no");
            Console.WriteLine("Do you plan to be in this home for 5 or more years?");

            if (GetChoice())
            {
                Console.WriteLine("Do you have an emergency fund?");
                if (GetChoice())
                {
                    Console.WriteLine("By the time of purchase, will you have enough cash saved for a 20% down payment plus fees?");
                    if (GetChoice())
                    {
                        Console.WriteLine("Will buying a home wipe out all your savings?");
                        if (!GetChoice())
                        {
                            Console.WriteLine("Can your budget handle not only the mortgage but the taxes, maintenance and incidental costs?");
                            if (GetChoice())
                            {
                                Console.WriteLine("Do you have a credit score of 600 or above?");
                                if (GetChoice())
                                {
                                    Console.WriteLine("Have you lived in that area before?");
                                    if (GetChoice())
                                    {
                                        Console.WriteLine("are you willing to be your own super (or pay someone else to do it?");
                                        if (GetChoice())
                                        {
                                            Console.WriteLine("Then you are ready to buy a house!!");
                                            Console.WriteLine("Happy House Hunting!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("You should Rent!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You should Rent!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You should Rent!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You should Rent!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You should Rent!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You should Rent!");
                    }
                }
                else
                {
                    Console.WriteLine("You should Rent!");
                }
            }
            else
            {
                Console.WriteLine("You should Rent!");
            }

            Console.ReadKey();
        }
    }
}