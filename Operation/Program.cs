using System;
using System.Globalization;

namespace Operation
{
    class Program
    {
        static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

        class Number
        {
            readonly int _number;

            public Number(int number)
            {
                _number = number;
            }

            public override string ToString()
            {
                return _number.ToString(_ifp);
            }
            
            /// <summary>
            /// перегрузка оператора сложения
            /// </summary>
            /// <param name="currentNumber">объект типа Number</param>
            /// <param name="otherNumber">число хранящееся в типе String</param>
            /// <returns>возвращает результат сложения объекта типа Number и второго аргумента типа String</returns>
            public static string operator +(Number currentNumber, string otherNumber) {
                string result = (currentNumber._number + int.Parse(otherNumber)).ToString();
                return result;
            }
        }

        static void Main(string[] args)
        {
            int someValue1 = 10;
            int someValue2 = 5;

            string result = new Number(someValue1) + someValue2.ToString(_ifp);
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}