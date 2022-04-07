using System;
using System.Diagnostics;

namespace TestTaskMTS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FailProcess();
            }
            catch	{		}

            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }

        static void FailProcess(){
            //... write your code here
            Process.GetCurrentProcess().Kill();
            Environment.Exit(444); //Указываем код ошибки при завершении
        }
    }
}