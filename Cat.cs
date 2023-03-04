using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stack
{
    public class Cat
    {
        private int hunger = 20;
        public string name;
        private int minhunger = 5;
        public bool alive = true;

        Random rand = new Random();

        public Cat(string name = "Безымянный")
        {
            this.name = name;

        }
        public void Meow()
        {
            if (alive)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine("Nothing is happening");
                Die();
            }
        }
        public string Name()
        {
            return name;
        }
        public void Eat(Food food)
        {
            if (alive == true)
            {
                Console.WriteLine($"Cat eats {food.type}. {food.health} HP");
                hunger += food.health;
            }
            Die();
        }
        public void Play()
        {
            if (alive)
            {
                Console.WriteLine("Cat is playing!");
                hunger -= 5;
                Die();
            }
        }
        public void Run()
        {
            if (alive)
            {
                Console.WriteLine("Cat is running!");
                hunger -= 5;
                Die();
            }
        }
        public void Die()
        {
            if (hunger < minhunger)
            {
                Console.WriteLine("the cat have starved, you didn't care for it well enough!");
                alive = false;
            }
            if (hunger < 10 && alive == true)
            {
                Meow();
            }
        }
        public void Health()
        {
            Console.WriteLine($"Cat feels this way: hunger: {hunger}");
        }
        public void Wait()
        {
            Console.WriteLine("\nWhile the cat is waiting it will do something random or do nothing at all.");
            int wait = rand.Next(1, 5);
            switch (wait)
            {
                case 1: Meow(); break;
                case 2: Run(); break;
                case 3: Play(); break;
                case 4: Console.WriteLine("It's just staring at the wall..."); break;
            }
        }
    }
}