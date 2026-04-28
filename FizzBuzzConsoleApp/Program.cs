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

             //test case 1
         var testCase1 = fizzBuzzer.FizzBuzzifyAnInt(1, 10);

         Console.WriteLine(testCase1);

         //test case 2
         fizzBuzzer.ReplacementPairs = new Dictionary<int, string> { { 2, "Even" } };
         var testCase2 = fizzBuzzer.FizzBuzzifyAnInt(1, 10);

         Console.WriteLine(testCase2);

         //test case 2
         fizzBuzzer.ReplacementPairs = new Dictionary<int, string> { { 2, "Quack" }, { 5, "Honk" } };
         var testCase3 = fizzBuzzer.FizzBuzzifyAnInt(1, 10);
        
         Console.WriteLine(testCase3);
        }
    }
}
