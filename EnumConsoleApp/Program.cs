using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsoleApp
{
    class Program
    {
        static void Main()
        {
            int x = (int)WeekDay.Sun;
            int y = (int)WeekDay.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);

            var description = WeekDay.Sun.ToDescription();
            Console.WriteLine("Sun description = {0}", description);

            var enumValue = WeekDay.Mon.ToInt();
            Console.WriteLine("Mon description = {0}", enumValue);

            Console.ReadLine();
        }
    }
}
