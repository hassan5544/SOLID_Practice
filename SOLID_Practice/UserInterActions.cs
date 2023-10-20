using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice
{
    public class UserInterActions
    {
        public static void  ShowOutput(string Message)
        {
            Console.WriteLine(Message);
        }

        public static int GetInput()
        {
            ConverterFunc<string, int> stringToIntConverter = Convert.ToInt32;

            var input = Console.ReadLine();
            int result = InputConverter.UseConverter(input, stringToIntConverter);
            return result;
        }
    }
}
