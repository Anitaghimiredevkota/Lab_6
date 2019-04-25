using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rolling_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            
                String userconsent;
                int input, dice1 = 0, dice2 = 0;
                string s;

                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice?(y/n): ");
                userconsent = Console.ReadLine();
                while (userconsent == "y")
                {

                    Console.WriteLine("How many sides should each dice have?");
                    s = Console.ReadLine();
                    bool success = int.TryParse(s, out input);
                    if (!success || input < 0)
                    {
                        Console.WriteLine("Enter valid number");
                    }
                    else
                    {

                        Program p = new Program();

                        dice1 = p.GetRandomNumber(input);
                        Console.WriteLine("Roll Outcome Dice1:" + dice1);

                        System.Threading.Thread.Sleep(500);
                        dice2 = p.GetRandomNumber(input);

                        Console.WriteLine("Roll Outcome Dice2:" + dice2);
                        Console.WriteLine("Do you want to continue? Roll the dice?(y/n): ");
                        userconsent = Console.ReadLine();
                    }
                }
            }
            public int GetRandomNumber(int diceNumber)
            {
                int output;
                Random rnd = new Random();
                if (diceNumber > 0)
                {
                    output = rnd.Next(1, (diceNumber + 1));

                }
                else
                {
                    output = 0;
                }

                return output;

            }

        }
    }





