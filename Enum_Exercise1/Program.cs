using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a day of the week: ");
            string userDay = Console.ReadLine();

            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                Console.WriteLine("The day of the week you chose was: " + day);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            finally
            {
                Console.ReadLine();
            }

        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }

}
