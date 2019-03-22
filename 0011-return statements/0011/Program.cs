using System;    // return statements//
namespace _0011
{
    class Program
    {
  static void Main(string[] args)
  {
  int cubeNumber = cube(5);
  Console.WriteLine(cubeNumber);
  Console.ReadLine();
  }
  static int cube(int num)
  {
   int result = num * num * num;
   return result;          } } }
