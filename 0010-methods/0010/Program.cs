using System;  //methods//
namespace _0010
{
  class Program
  {
static void Main(string[] args)
{
SayHi("Paddy", 55);
SayHi("John", 66);
SayHi("Peter", 354);
Console.ReadLine();
}
static void SayHi( string name, int age )
{
Console.WriteLine("hello " + name + " you are " + age);
  }  } }
