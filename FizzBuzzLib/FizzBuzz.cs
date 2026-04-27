namespace FizzBuzzLib
{
     //inherit interface - cw
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }

        
        //implement interface - cw
        public string FizzBuzzifyAnInt(int input)
        {
            try
            {
                //test first for both conditions - cw
                if (input % 3 == 0 && input % 5 == 0)
                {
                    return "FizzBuzz";
                }
                //test only for divisable by three - cw
                else if (input % 3 == 0)
                {
                    return "Fizz";
                }
                //test only for divisable by five - cw
                else if (input % 5 == 0)
                {
                    return "Buzz";
                }
                //if tests fail, return int as string
                else
                {
                    return input.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

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
