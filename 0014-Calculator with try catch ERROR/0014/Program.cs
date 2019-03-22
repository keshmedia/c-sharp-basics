using System;   // Calculator with try catch ERROR //
namespace _0014
{
   class Program
  {
      static void Main(string[] args)
   { try
   {
  Console.Write("enter a number: "); double num1 = Convert.ToDouble(Console.ReadLine());
  Console.Write("enter operator: ");   string op = Console.ReadLine();
  Console.Write("enter a number: ");  double num2 = Convert.ToDouble(Console.ReadLine());
  if (op == "+") { Console.WriteLine(num1 + num2);  } else if (op == "-")
  { Console.WriteLine(num1 - num2);  }
  else if (op == "/") { Console.WriteLine(num1 / num2); }
  else if (op == "*") { Console.WriteLine(num1 * num2); }
  else { Console.WriteLine("Invalid Operator"); }
   }catch {  Console.WriteLine("ERROR !!!!!!!! TRY AGAIN");
   }   Console.ReadLine();        }  } }
