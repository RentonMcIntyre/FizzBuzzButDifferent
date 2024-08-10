namespace FizzBuzzRules
{
    [FizzBuzzRule(2)]
    public class BuzzRule : IFizzBuzzRule
    {
        /// <summary>
        /// Checks whether the given number is divisible by 3 and returns either "Buzz" or null
        /// </summary>
        /// <param name="number">The number upon which to apply the rule.</param>
        /// <returns>A string value "Fizz" or null</returns>
        public string? GetRuleResult(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return null;
        }
    }
}
