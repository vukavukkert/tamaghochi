using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stack
{
    public class Dog
    {
        private int hunger = 30;
        public string name;
        private int minhunger = 5;
        public bool alive = true;

        Random rand = new Random();
        public Dog(string name = "Безымянный")
        {
            this.name = name;
        }

        public void Bark()
        {
            if (alive)
            {
                Console.WriteLine("Bark");
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
        public void Health()
        {
            Console.WriteLine($"Dog feels this way: hunger: {hunger}");
        }
        public void Eat(Food food)
        {
            if (alive == true)
            {
                Console.WriteLine($"Dog eats {food.type}. {food.health} HP");
                hunger += food.health;
            }
            Die();
        }
        private void Die()
        {
            if (hunger < minhunger)
            {
                Console.WriteLine("the dog have starved, you didn't care for it well enough!");
                alive = false;
            }
            if (hunger < 10 && alive == true)
            {
                Bark();
            }
        }
        public void Play()
        {
            if (alive)
            {
                Console.WriteLine("Dog is playing!");
                hunger -= 5;
                Die();
            }
        }
        public void Run()
        {
            if (alive)
            {
                Console.WriteLine("Dog is running!");
                hunger -= 5;
                Die();
            }

        }
        public void Wait()
        {
            Console.WriteLine("\nWhile the dog is waiting it will do something random or do nothing at all.");
            int wait = rand.Next(1, 5);
            switch (wait)
            {
                case 1: Bark(); break;
                case 2: Run(); break;
                case 3: Play(); break;
                case 4: Console.WriteLine("It's just staring at the wall..."); break;
            }
        }
    }
}