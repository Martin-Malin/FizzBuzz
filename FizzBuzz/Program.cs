namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var fizzBuzz = new FizzBuzz(i);

                Console.WriteLine(i.ToString() + " => " + fizzBuzz.Result);
            }
            Console.ReadKey();
        }
    }
}