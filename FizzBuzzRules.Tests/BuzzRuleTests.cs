namespace FizzBuzzRules.Tests
{
    public class BuzzRuleTests
    {
        [Fact]
        public void BuzzRule_Returns_Null_For_Argument_Not_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Null(rule.GetRuleResult(1));
            Assert.Null(rule.GetRuleResult(8));
            Assert.Null(rule.GetRuleResult(14));
        }

        [Fact]
        public void BuzzRule_Returns_Buzz_For_Argument_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Equal("Buzz", rule.GetRuleResult(5));
            Assert.Equal("Buzz", rule.GetRuleResult(10));
            Assert.Equal("Buzz", rule.GetRuleResult(15));
        }

        [Fact]
        public void BuzzRule_Returns_Null_For_Large_Argument_Not_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Null(rule.GetRuleResult(1073));
        }

        [Fact]
        public void BuzzRule_Returns_Buzz_For_Large_Argument_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Equal("Buzz", rule.GetRuleResult(770));
        }

        [Fact]
        public void BuzzRule_Returns_Buzz_For_Zero()
        {
            var rule = new BuzzRule();

            Assert.Equal("Buzz", rule.GetRuleResult(0));
        }

        [Fact]
        public void BuzzRule_Returns_Null_For_Negative_Not_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Null(rule?.GetRuleResult(-1));
            Assert.Null(rule?.GetRuleResult(-8));
            Assert.Null(rule?.GetRuleResult(-14));
        }

        [Fact]
        public void BuzzRule_Returns_Buzz_For_Negative_Divisible_By_Five()
        {
            var rule = new BuzzRule();

            Assert.Equal("Buzz", rule.GetRuleResult(-5));
            Assert.Equal("Buzz", rule.GetRuleResult(-10));
            Assert.Equal("Buzz", rule.GetRuleResult(-15));
        }
    }
}