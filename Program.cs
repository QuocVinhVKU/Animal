using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{

    class AbstractAndInterfaceTests
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }
        }
    }
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }

    public interface Edible
    {
        public string HowToEat();
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
}
