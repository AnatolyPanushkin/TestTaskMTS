using System;
using System.IO;

namespace ElephantOfFly
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformToElephant();
            Console.WriteLine("Муха");
            //... custom application code
            Console.WriteLine("dsfsdf");
        }

        static void TransformToElephant()
        {
            //... write your code here 	}
            unsafe
            {
                ReadOnlySpan<char> elephant = "Слон";
                fixed (char* ptr = "Муха") 
                    elephant.CopyTo(new Span<char>(ptr, 4));
                
            }
        }

    }
}