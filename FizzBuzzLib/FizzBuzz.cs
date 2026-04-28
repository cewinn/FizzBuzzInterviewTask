namespace FizzBuzzLib
{
     //inherit interface - cw
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {

        public Dictionary<int, string>? ReplacementPairs { get; set; }
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }

      //set parameter to recieve range of 1-10 - cw
      //set return to string array, e.g. "1", "2", "Fizz"...
      //method called in program - second commit for question due to GitHub Online
      //Instructions read to require a string[] and test a range- Result sequence should be {"1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even"}
      public string[] FizzBuzzifyAnInt(int start, int end )
      {
     
         
              if (ReplacementPairs.Count() == 0)
              {
                  ReplacementPairs = (new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } });
              }

              //create range for test 1 -10 and cast to int - cw
              int[] testArray = Enumerable.Range(start, end).ToArray();
              string[] returnValues = new string[10];
     
              foreach (var number in testArray)
              {
                  if (!ReplacementPairs.ContainsKey(number))
                  {
                      returnValues[number - 1] = number.ToString();
                  }
     
                  else {
                      foreach (var pair in ReplacementPairs) {
                          if (number % pair.Key == 0) {
                               if (returnValues[pair.Key - 1].Length == 0)
                               {
                                   returnValues[pair.Key - 1] = pair.Value;
                               }
                               else
                               {
                                   returnValues[pair.Key - 1] = returnValues[pair.Key - 1] + pair.Value;
                               }
                          }
                      }

                  }
              }
     
              return returnValues;
      }
      //implement FizzBuzzRange
      public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
      {
          //create empty list for return - cw
          List<string> fizzBuzzedString = new List<string>();
     
          try
          {     
              //create range and cast to int - cw
              int[] intArray = Enumerable.Range(start, end).ToArray();
     
              //enumerate through and call FizzBuzzifyAnInt - cw
              //add returned value to list - cw
              foreach (int i in intArray)
              {
                  var fizzed = FizzBuzzifyAnInt(i);
                  if (fizzed != null)
                  {
                      fizzBuzzedString.Add(fizzed);
                  }
              }
     
              //return list as enumerable implicit - cw
              return fizzBuzzedString;
          }
          catch (Exception ex)
          {
              //exception return message - cw
              fizzBuzzedString.Add(ex.Message);
              return fizzBuzzedString;
          }
      }
    }
}
