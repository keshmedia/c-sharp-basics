using System;   //switch statements//
namespace _0018
{
class Program
    {  static void Main(string[] args)   { Console.WriteLine(GetDay(5)); 
  Console.ReadLine();   }  static string GetDay(int dayNum)  {
 string dayName; switch (dayNum)
            {
    case 0:   dayName = "SUNDAY";                     break;
    case 1:   dayName = "MONDAY";                     break;
    case 2:   dayName = "TUESDAY";                    break;
    case 3:   dayName = "WEDNESDAY";              break;
    case 4: dayName = "THURDAY";                      break;
    case 5:   dayName = "FRIDAY";                         break;
    case 6: dayName = "SATURDAY";                     break;
 default:  dayName = "INVALID DAY NUMBER";    break; }
            return dayName;   }  } }
