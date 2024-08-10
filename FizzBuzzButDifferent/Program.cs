// See https://aka.ms/new-console-template for more information

using FizzBuzzRuleRunner;

Runner runner = new();
runner.LoadRules();

var numberList = Enumerable.Range(1, 100).ToList();

foreach (var number in numberList)
{
    var ruleResult = runner.GetRuleResult(number);
    Console.WriteLine(ruleResult);
}