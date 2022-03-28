using System;
using System.Collections;
using System.Collections.Generic;

namespace CoreLogic
{
    public  class FizzBuzzCore
    {
        public string[] FizzBuzz(int[] input)
        {

            List<string> outputHash =new  List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                outputHash.Add(performValidation(input[i]));
            }

            return outputHash.ToArray();
        }
        public  string performValidation(int input)
        {
            if (!isValidInput(input.GetTypeCode()))
            {
                return "Invalid Item";
            }
            else
            {
                if (isDivisibleByBoth(input))
                {
                    return "FizzBuzz";
                }
                else if (isDivisibleBy3(input))
                {
                    return "Fizz";
                }
                else if (isDivisibleBy5(input))
                {
                    return "Buzz";
                }
                else
                {
                    DisplayResult($"Divided {input} by 3 / Divided {input} by 5");
                    return $"Divided {input} by 3 / Divided {input} by 5";
                }

            }
        }
        public  bool isValidInput(TypeCode value)
        {
            return (TypeCode.Int32 == value) ? true : false;
        }
        public  bool isDivisibleBy3(int val)
        {
            if ((val % 3 == 0))
            {
                DisplayResult("Fizz");
                return true;
            }
            return false;

        }
        public  bool isDivisibleBy5(int val)
        {
            if ((val % 5 == 0))
            {
                DisplayResult("Buzz");
                return true;
            }
            return false;
        }
        public  bool isDivisibleByBoth(int val)
        {
            if ((val % 5 == 0) && (val % 3 == 0))
            {
                DisplayResult("FizzBuzz");
                return true;
            }
            return false;
        }
        public static  void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }

    
}
