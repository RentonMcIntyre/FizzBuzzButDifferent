# FizzBuzzButDifferent

This is a simple program that applies a series of rules to a range of numbers and prints the results.

The rules are implemented as classes that implement the `IFizzBuzzRule` interface. The `FizzBuzzRuleRunner` class aggregates all the rules and applies them to a given number. The rules are loaded from the assembly `FizzBuzzRules`.

The rules are applied in the order they are defined in the assembly. The order is defined by the `FizzBuzzRuleAttribute` on the class. The attribute has a single property, `Order`, which is used to determine the order in which the rules are applied.

## Runner
The runner is implemented in the `FizzBuzzRuleRunner` project. It locates all the rules in the assembly `FizzBuzzRules` and applies them to a given number in order. This will allow easy addition of new rules without having to modify the runner.

## Rules

There are two rules implemented in this project:

1. FizzRule
2. BuzzRule

### FizzRule

This rule checks whether the number is divisible by 3. If it is, it returns "Fizz". If not, it returns null.

### BuzzRule

This rule checks whether the number is divisible by 5. If it is, it returns "Buzz". If not, it returns null.

## Unit Tests
Unit tests for the rules are provided under the `FizzBuzzRules.Tests` project. The tests are written using the xUnit framework.
Unit tests for the runner are provided under the `FizzBuzzRuleRunner.Tests` project. The tests are written using the xUnit framework.

## PS
Please note that while the first and last commit have significant time gaps, this is just due to when I created the project. I didn't immediately start working on it until commit #3. 
