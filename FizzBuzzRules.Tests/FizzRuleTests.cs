namespace FizzBuzzRules.Tests
{
    public class FizzRuleTests
    {
        [Fact]
        public void FizzRule_Returns_Null_For_Argument_Not_Divisible_By_Three()
        {
            var rule = new FizzRule();

            Assert.Null(rule.GetRuleResult(1));
            Assert.Null(rule.GetRuleResult(8));
            Assert.Null(rule.GetRuleResult(14));
        }

        [Fact]
        public void FizzRule_Returns_Fizz_For_Argument_Divisible_By_Three()
        {
            var rule = new FizzRule();

            Assert.Equal("Fizz", rule.GetRuleResult(3));
            Assert.Equal("Fizz", rule.GetRuleResult(9));
            Assert.Equal("Fizz", rule.GetRuleResult(15));
        }

        [Fact]
        public void FizzRule_Returns_Null_For_Large_Argument_Not_Divisible_By_Three()
        {
            var rule = new FizzRule();

            Assert.Null(rule.GetRuleResult(1073));
        }

        [Fact]
        public void FizzRule_Returns_Fizz_For_Large_Argument_Divisible_By_Three()
        {
            var rule = new FizzRule();

            Assert.Equal("Fizz", rule.GetRuleResult(768));
        }

        [Fact]
        public void FizzRule_Returns_Fizz_For_Zero()
        {
            var rule = new FizzRule();

            Assert.Equal("Fizz", rule.GetRuleResult(0));
        }

        [Fact]
        public void FizzRule_Returns_Null_For_Negative_Divisible_By_Three()
        {
            var rule = new FizzRule();

            Assert.Null(rule?.GetRuleResult(-1));
            Assert.Null(rule?.GetRuleResult(-8));
            Assert.Null(rule?.GetRuleResult(-14));
        }
    }
}