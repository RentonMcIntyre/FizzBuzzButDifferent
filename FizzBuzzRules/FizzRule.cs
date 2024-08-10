namespace FizzBuzzRules
{
    [FizzBuzzRule(1)]
    public class FizzRule : IFizzBuzzRule
    {
        /// <summary>
        /// Checks whether the given number is divisible by 3 and returns either "Fizz" or null
        /// </summary>
        /// <param name="number">The number upon which to apply the rule.</param>
        /// <returns>A string value "Fizz" or null</returns>
        public string? GetRuleResult(int number)
        {
            if (number % 3 == 0) {
                return "Fizz";
            }

            return null;
        }
    }
}
