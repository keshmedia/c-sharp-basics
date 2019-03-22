using System; // if statements //
namespace _0012
{
    class Program
    {
 static void Main(string[] args)
 {
   bool isMale = false;
   bool isTall = false;
   if (isMale || isTall) // &&  ||   and or // 
            {
   Console.WriteLine("you are a tall male");
   } else if (isMale && !isTall) { // ! not //
   Console.WriteLine("you are a short male");
   } else if (!isMale && isTall) {
  Console.WriteLine("you are not male but you are tall");
   } else {
  Console.WriteLine("you are either not male or not tall");
   }         Console.ReadLine();   }  }}
