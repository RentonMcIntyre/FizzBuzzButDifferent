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

        public IEnumerable<string> LoadedRuleNames => Rules.Select(rule => rule.GetType().Name);
    }
}
