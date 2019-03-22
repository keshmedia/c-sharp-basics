using System;
namespace _0017
{
public class Program
  {
      static void Main(string[] args)
      {
Book book1 = new Book("Harry Potter", "JK Rowling", 400);
Book book2 = new Book("Lord of the rings", "Tolkein", 7000);

Console.WriteLine(book1.title);
Console.WriteLine(book1.author);
Console.WriteLine(book1.pages); 

Console.WriteLine(book2.title);
Console.WriteLine(book2.author);
Console.WriteLine(book2.pages);
            Console.ReadLine();
 }  } }
