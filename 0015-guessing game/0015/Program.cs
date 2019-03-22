using System;   //guessing game//
namespace _0015
{
    class Program
    {
     static void Main(string[] args)
    {
 string secretWord = "cat"; // answer //
string guess = "";    int guessCount = 0;
 int guessLimit = 3; //set guess number
 bool outOfGuesses = false;   while (guess != secretWord && !outOfGuesses)
 {   if (guessCount < guessLimit)  {
  Console.Write("enter guess: ");  guess = Console.ReadLine();  guessCount++;
 }   else { outOfGuesses = true; } }
 if (outOfGuesses)  {   Console.Write("You Lose !!!!");   }
 else { Console.Write("You Win !!!!"); }
 Console.ReadLine();              }  }}