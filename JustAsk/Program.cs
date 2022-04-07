using System;
using System.Collections.Generic;
using System.Linq;

namespace JustAsk
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            var res = new[] { 1, 2, 3, 4,8,5 }.EnumerateFromTail(4); 
            
            foreach (var t in res)
            {
                
                Console.WriteLine($"({t.item},{t.tail})");
            }

        }
        /// <summary>
        /// <para> Отсчитать несколько элементов с конца </para>
        /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
        /// </summary> 
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
        /// <returns></returns>
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
           T[] arr = enumerable.ToArray();
           List<(T item, int? tail)> result = new List<(T item, int? tail)>();
           int count = 0;
           for (int i=0; i <arr.Length; i++)
           { 
               if (i < tailLength)
               { 
                    result.Add((arr[arr.Length - i - 1], count)); 
                    count++;
               }
               else
               {
                   result.Add((arr[arr.Length - i - 1], null));
               }
           }
           return result;
        }
    }
}