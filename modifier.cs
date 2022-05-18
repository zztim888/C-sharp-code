using System;

namespace MyApp
{
    class Car
{
    //By default, all members of a class are private if you don't specify an access modifier:
    // if yo write private it wont be accesible by another class
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}

}