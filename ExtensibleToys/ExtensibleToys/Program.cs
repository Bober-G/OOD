using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adding collection of dresses, dances and stories
            
            string[] dressPattern = { "dotted", "flower" };
            string[] danceStyles = { "breakdance", "solo capoeira", "gangam style dance"};
            string[] storyTypes = { "scary", "jokes"};
            
            
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();
            

            List<IToy> toys = new List<IToy> { doll, warrior, raceDriver };

            Console.WriteLine("Printing basic Summaries and Prices of toys.\n");
            {
                foreach(var t in toys)
                {
                    Console.WriteLine($"{t.Summary()}, Price:{t.Cost()}");
                }
            }

            Console.WriteLine("\ntesting the elements i can add to toys.\n");
            {
                Decorator toy1 = new Dress(toys[0], dressPattern[1]);
                toy1 = new Dance(toy1, danceStyles[0]);
                toy1 = new Helmet(toy1);
                Console.WriteLine($"{toy1.Summary()}, Price:{toy1.Cost()}");
                Console.WriteLine("------------------------------------");
                Decorator toy2 = new Sword(toys[2]);
                toy2 = new Jump(toy2);
                toy2 = new Story(toy2, storyTypes[1]);
                Console.WriteLine($"{toy2.Summary()}, Price:{toy2.Cost()}");
            }
            
            Console.WriteLine("\ntesting adding at least 6 jumps.\n");
            {
                Decorator Doll = new Jump(doll);
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(Doll.Summary());
                    Console.WriteLine($"Price: {Doll.Cost()}");
                }
            }
            
            Console.WriteLine("\ntesting adding multiple dances.\n");
            {
                Decorator toy3 = new Dance(toys[1], danceStyles[0]);
                toy3 = new Dance(toy3, danceStyles[2]);
                Console.WriteLine($"{toy3.Summary()}, Price:{toy3.Cost()}");
            }

            IToy minotaur = new Minotaur("alan", 10, 100);
            IToy centaur = new Centaur("darek", 8, false);

            Console.WriteLine("Adding Minotaur and Centaur to toys");
            {
                toys.Add(minotaur);
                toys.Add(centaur);
                foreach(var t in toys)
                {
                    Console.WriteLine($"{t.Summary()}, Price:{t.Cost()}");
                }
            }

            Console.WriteLine("Adding elements to minotaur and centaur");
            {
                Decorator toy4 = new Sword(toys[3]);
                Decorator toy5 = new Helmet(toys[4]);
                Console.WriteLine($"{toy4.Summary()}, Price:{toy4.Cost()}");
                Console.WriteLine($"{toy5.Summary()}, Price:{toy5.Cost()}");

            }





        }
    }
}
