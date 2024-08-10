namespace FizzBuzzRules
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FizzBuzzRuleAttribute: Attribute
    {
        public int Order { get; }

        public FizzBuzzRuleAttribute(int order)
        {
            Order = order;
        }
    }
}
