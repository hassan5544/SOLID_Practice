using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmellyCodeExample;

namespace SOLID_Practice
{
    public delegate TOutput ConverterFunc<TInput, TOutput>(TInput input);

    public class InputConverter
    {
        public static TOutput UseConverter<TInput, TOutput>(TInput value, ConverterFunc<TInput, TOutput> converter)
        {
            TOutput result = converter(value);
            return result;
        }
    }
}
