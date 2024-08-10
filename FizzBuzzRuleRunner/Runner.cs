using FizzBuzzRules;
using System.Reflection;

namespace FizzBuzzRuleRunner
{
    /// <summary>
    /// Handles aggregation and running of IFizzBuzzRules
    /// </summary>
    public class Runner
    {
        private IList<IFizzBuzzRule> Rules { get; set; }

        public Runner() { 
            Rules = new List<IFizzBuzzRule>();
        }

        /// <summary>
        /// Load all the implementations of IRule, from assembly FizzBuzzRules
        /// </summary>
        public void LoadRules()
        {
            Rules = new List<IFizzBuzzRule>();

            var ruleAssembly = Assembly.Load("FizzBuzzRules");

            var ruleTypes = ruleAssembly.GetTypes()
                                        .Where(type => typeof(IFizzBuzzRule).IsAssignableFrom(type)
                                        && type.GetCustomAttribute<FizzBuzzRuleAttribute>() != null);

            InstantiateRules(ruleTypes);
        }

        /// <summary>
        /// Applies all rules to the given number and returns the rule results, or, if none are applicable, returns the number.
        /// </summary>
        /// <param name="number">The number upon which to apply rules.</param>
        /// <returns>The number or the aggregate of the rule results.</returns>
        public string GetRuleResult(int number)
        {
            return number.ToString();
        }

        public IEnumerable<string> LoadedRuleNames => Rules.Select(rule => rule.GetType().Name);

        /// <summary>
        /// Create instances of all rule objects. We will allow skipping if a failure to create an instance occurs, for now.
        /// </summary>
        /// <param name="ruleTypes">The types of all rules to instantiate</param>
        private void InstantiateRules(IEnumerable<Type> ruleTypes)
        {
            foreach (var item in ruleTypes)
            {
                IFizzBuzzRule? rule = Activator.CreateInstance(item) as IFizzBuzzRule;
                if (rule == null)
                    continue;

                Rules.Add(rule);
            }
        }
    }
}
