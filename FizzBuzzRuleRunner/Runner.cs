using FizzBuzzRules;

namespace FizzBuzzRuleRunner
{
    public class Runner
    {
        private IEnumerable<IFizzBuzzRule> Rules { get; set; }

        public Runner() { 
            Rules = new List<IFizzBuzzRule>();
        }

        public void LoadRules()
        {
            Rules = new List<IFizzBuzzRule>();
        }

        public IEnumerable<string> LoadedRuleNames => Rules.Select(rule => rule.GetType().Name);
    }
}
