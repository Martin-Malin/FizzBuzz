namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int _number;

        public string Result
        {
            get
            {
                string result = "";
                if (IsFizz())
                    result += "Fizz";

                if (IsBuzz())
                    result += "Buzz";

                return String.IsNullOrEmpty(result) ? _number.ToString() : result;
            }
        }

        public FizzBuzz(int number)
        {
            _number = number;
        }

        private bool IsFizz()
        {
            return ContainsThree() || IsDivisibleByThree();
        }

        private bool ContainsThree()
        {
            string numberString = _number.ToString();
            return numberString.Contains("3");
        }

        private bool IsDivisibleByThree()
        {
            return _number % 3 == 0;
        }

        private bool IsBuzz()
        {
            return ContainsFive() || IsDivisibleByFive();
        }

        private bool ContainsFive()
        {
            string numberString = _number.ToString();
            return numberString.Contains("5");
        }

        private bool IsDivisibleByFive()
        {
            return _number % 5 == 0;
        }
    }
}
