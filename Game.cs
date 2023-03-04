using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stack
{
    public class Game
    {
        static public void gameCat()
        {
            Console.WriteLine("Cats? Okay. Name your cat!");
            string catname = Console.ReadLine();
            Cat cat = new Cat(catname);
            cat.Meow();
            ConsoleKeyInfo key;

            while (cat.alive == true)
            {
                Console.WriteLine("Press the 'A' button to feed the cat, press the 'P' button to play, press any other button to wait.");
                key = Console.ReadKey();
                cat.Health();
                if (key.Key == ConsoleKey.A)
                {

                    Console.WriteLine("What do you want to feed it?");
                    string name = Console.ReadLine();
                    Console.WriteLine("And how tasty that is?");
                    int saturation = int.Parse(Console.ReadLine());
                    if (saturation > 20) Console.WriteLine("Well it can't be that healthy!");
                    if (saturation < -5) Console.WriteLine("That's is not edible!");
                    if (saturation < 20 && saturation > -5)
                    {
                        var food = new Food { type = name, health = saturation };
                        Feed(cat, food);
                    }
                }
                if (key.Key == ConsoleKey.P)
                {
                    cat.Play();
                }
                cat.Wait();
                cat.Health();
                System.Threading.Thread.Sleep(200);
            }
            static void Feed(Cat cat, Food food)
            {
                cat.Eat(food);
            }
        }
        static public void gameDog()
        {
            Console.WriteLine("Dogs? Okay. Name your dog!");
            string dogname = Console.ReadLine();
            Dog dog = new Dog(dogname);
            dog.Bark();
            ConsoleKeyInfo key;

            while (dog.alive == true)
            {
                Console.WriteLine("Press the 'A' button to feed the dog, press the 'P' button to play, press any other button to wait.");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {

                    Console.WriteLine("What do you want to feed it?");
                    string name = Console.ReadLine();
                    Console.WriteLine("And how tasty that is?");
                    int saturation = int.Parse(Console.ReadLine());
                    if (saturation > 20) Console.WriteLine("Well it can't be that healthy!");
                    if (saturation < -5) Console.WriteLine("That's is not edible!");
                    if (saturation < 20 && saturation > -5)
                    {
                        var food = new Food { type = name, health = saturation };
                        Feed(dog, food);
                    }
                }
                if (key.Key == ConsoleKey.P)
                {
                    dog.Play();
                }
                dog.Wait();
                dog.Health();
                System.Threading.Thread.Sleep(200);
            }
            static void Feed(Dog dog, Food food)
            {
                dog.Eat(food);
            }
        }
    }
}