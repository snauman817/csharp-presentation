using System;

namespace PresentationCode
{
    public class Animal
    {
        public string noise;
        public string name;

        public Animal()
        {
            this.name = "Animal";
            this.noise = "nothing";
        }
        public Animal(string name)
        {
            this.name = name;
            this.noise = "nothing";
        }

        public string getName()
        {
            return this.name;
        }
        public string getNoise()
        {
            return this.noise;
        }

        public void makeNoise()
        {
            Console.WriteLine("The " + this.getName() + " says " + this.getNoise());
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            this.noise = "bark";
        }
    }



    public class Zoo
    {
        public static void Main()
        {
            Animal animal1 = new Animal("Jake");
            Dog dog1 = new Dog("Dog");

            animal1.makeNoise();
            dog1.makeNoise();
        }
    }
}