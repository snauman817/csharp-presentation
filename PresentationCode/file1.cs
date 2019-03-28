using System;

namespace PresentationCode
{
    public class Person
    {
        public string name;

        public Person()
        {
            this.name = "World";
        }
        public Person(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }

    public class Room
    {
        public Person person1 = new Person("Jeff");
        public Person person2 = new Person("Rick");

        public Room(){
            
        }
        public string greet()
        {
            return "Hello, " + person1.getName() + ". My name is " + person2.getName() + ".";
        }
    }

    public class Greeting
    {
        public void Main(string[] args)
        {
            new Room();
        }
    }

    // public class GreetingImproved
    // {
    //     public GreetingImproved(Person person1, Person person2)
    //     {
            
    //     }
    // }
}
