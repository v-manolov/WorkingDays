using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution9_WorkingDays;

namespace Solution9_WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now.Date;
            Console.WriteLine("Please enter a date after {0:dd.MM.yyyy} :",currentDate);
            DateTime nextDate = DateTime.Parse(Console.ReadLine());
            Console.Write("The period from {0:dd.MM.yyyy} to {1:dd.MM.yyyy} has ",currentDate,nextDate);
            Console.WriteLine("{0} working days.",WorkingDays.CountWorkingDays(currentDate,nextDate));
            Console.ReadLine(); 
        }
    }
}
