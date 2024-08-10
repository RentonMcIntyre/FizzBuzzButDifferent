namespace FizzBuzzRuleRunner.Tests
{
    public class RunnerTests
    {
        [Fact]
        public void Runner_Can_Locate_Rules()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.NotEmpty(runner.LoadedRuleNames);
        }

        [Fact]
        public void Runner_Loads_Expected_Number_Of_Rules()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Equal(2, runner.LoadedRuleNames.Count());
        }

        [Fact]
        public void Runner_Loads_Fizz_Rule()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Contains("FizzRule", runner.LoadedRuleNames);
        }

        [Fact]
        public void Runner_Loads_Buzz_Rule()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Contains("BuzzRule", runner.LoadedRuleNames);
        }
    }
}