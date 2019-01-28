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
        public static void Main(string[] args)
        {
            EnterValidDate();
        }
        static void EnterValidDate()
        {
            DateTime currentDate = DateTime.Now.Date;
            Console.WriteLine("Please enter a date after {0:dd.MM.yyyy} :", currentDate);
            DateTime nextDate = DateTime.Parse(Console.ReadLine());
            if ((nextDate - currentDate).Days >= 0)
            {
                Console.Write("The period from {0:dd.MM.yyyy} to {1:dd.MM.yyyy} has ", currentDate, nextDate);
                Console.WriteLine("{0} working days.", WorkingDays.CountWorkingDays(currentDate, nextDate));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have entered a date before {0:dd.MM.yyyy}",currentDate);
                EnterValidDate();
            }
        }

    }
}
