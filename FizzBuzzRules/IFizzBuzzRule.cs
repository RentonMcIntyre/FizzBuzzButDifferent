namespace FizzBuzzRules
{
    public interface IFizzBuzzRule
    {
        /// <summary>
        /// Apply the rule to an input value and return a result accordingly
        /// </summary>
        /// <param name="number">The number upon which to apply the rule.</param>
        /// <returns>The string the rule returns if it applies, or null if it does not</returns>
        string? GetRuleResult(int number);
    }
}
