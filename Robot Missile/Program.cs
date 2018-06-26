using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Missile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROBOT MISSILE");
            Console.WriteLine();
            Console.WriteLine("TYPE THE CORRECT CODE");
            Console.WriteLine("LETTER (A-Z) TO");
            Console.WriteLine("DEFUSE THE MISSILE.");
            Console.WriteLine("YOU HAVE 4 CHANCES");
            Console.WriteLine();

            var code = Convert.ToChar(new Random().Next(65, 90));
            bool defused = false;
            for (int attempt=0; attempt <4; attempt++)
            {
                var guess = Console.ReadKey(true);
                if (char.ToUpper(guess.KeyChar) == code)
                {
                    defused = true;               
                    break;
                }
                else
                {
                    if (char.ToUpper(guess.KeyChar) < code)
                    {
                        Console.Write("LATER");
                    }
                    else
                    {
                        Console.Write("EARLIER");
                    }
                    Console.WriteLine(" THAN " + char.ToUpper(guess.KeyChar));
                }
            }

            if (defused)
            {
                Console.WriteLine("TICK...FZZZZ...CLICK...");
                Console.WriteLine("YOU DID IT");
            }
            else
            {
                Console.WriteLine("BOOOOOOOOMMM...");
                Console.WriteLine("YOU BLEW IT");
                Console.WriteLine("THE CORRECT CODE WAS " + code);
            }

            Console.ReadKey(true);
        }
    }
}
