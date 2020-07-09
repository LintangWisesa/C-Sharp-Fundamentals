using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string userName = Console.ReadLine();
      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Hello " + userName + ", you're " + age + " yo.");   
    }
  }
}