using System;

namespace MyApp
{
    class Animal
    {
        // with word virtual and override
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig:Animal
    {         public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog:Animal
    {         public override void animalSound()
        {
            Console.WriteLine("The Dog backs: woof woof");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();  

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();         
     
        } 
    }

}