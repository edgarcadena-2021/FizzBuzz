using CoreLogic;

namespace FizzBuzzApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzCore fizzBuzzCore = new FizzBuzzCore();
            var result = fizzBuzzCore.FizzBuzz(new int[] {1,3,5,15,23 });
        }
    }
}
