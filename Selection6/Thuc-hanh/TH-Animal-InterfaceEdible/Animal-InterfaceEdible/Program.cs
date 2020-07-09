using System;

namespace Animal_InterfaceEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Animal
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    IEdible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }

            // Test Fruit
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}
