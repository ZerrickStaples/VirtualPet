using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            
            
            Console.WriteLine("Welcome to the virtual pet simiulator\nPlease press 'Enter' to continue.");
            Console.ReadLine();
            Console.WriteLine("This is your new tiger, Tupac. Please take care of him, if his health reaches 0 then you lose.");
            Console.ReadLine();



            {   //Scoreboard
                virtual_pet Tupac = new virtual_pet("Tupac The Tiger", 60, 20, 20, 20);

                //Options
                Console.WriteLine("Please pick an activity.");
                Console.WriteLine();

                Console.WriteLine("1: Eat");

                Console.WriteLine("2: Drink");

                Console.WriteLine("3: Play");

                Console.WriteLine("4: Relieve");

                Console.WriteLine("5: Quit");

                int answer = int.Parse(Console.ReadLine());
                
                //linking methods and tick
                for (int i = 0; i <= 30; i++)
                {
                    Tupac.PrintAllDetails();
                    Tupac.Tick(answer);
                    System.Threading.Thread.Sleep(5000);
                    continue;
                }


                
                

               

                
            }
        }
  }
}
