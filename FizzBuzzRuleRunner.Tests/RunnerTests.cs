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

        [Fact]
        public void Runner_Applies_Rules_Correctly_For_No_Applicable_Rule()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Equal("1", runner.GetRuleResult(1));
            Assert.Equal("8", runner.GetRuleResult(8));
            Assert.Equal("14", runner.GetRuleResult(14));
        }

        [Fact]
        public void Runner_Applies_Rules_Correctly_For_Input_Only_Applicable_To_Fizz()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Equal("Fizz", runner.GetRuleResult(3));
            Assert.Equal("Fizz", runner.GetRuleResult(9));
            Assert.Equal("Fizz", runner.GetRuleResult(12));
        }

        [Fact]
        public void Runner_Applies_Rules_Correctly_For_Input_Only_Applicable_To_Buzz()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Equal("Buzz", runner.GetRuleResult(5));
            Assert.Equal("Buzz", runner.GetRuleResult(10));
            Assert.Equal("Buzz", runner.GetRuleResult(20));
        }

        [Fact]
        public void Runner_Applies_Rules_Correctly_For_Input_Applicable_To_Fizz_And_Buzz()
        {
            var runner = new Runner();
            runner.LoadRules();

            Assert.Equal("FizzBuzz", runner.GetRuleResult(15));
            Assert.Equal("FizzBuzz", runner.GetRuleResult(30));
            Assert.Equal("FizzBuzz", runner.GetRuleResult(45));
        }

    }
}