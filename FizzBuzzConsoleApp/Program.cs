namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzRange range = new FizzBuzz();

             var fizzBuzzRange = range.FizzBuzzValuesForRange(1, 100);
            
             foreach(var item in fizzBuzzRange)
             {
                 Console.WriteLine(item);
             }
        }
    }
}
