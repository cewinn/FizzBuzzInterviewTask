namespace FizzBuzzLib
{
     //inherit interface - cw
    public class FizzBuzz : IFizzBuzz
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
    }
}
