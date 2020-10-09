Feature: UsingCalculatorFactorial
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Factorial
Scenario: Factorial of a number
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factoroial result should be "120"

@Factorial
Scenario: Factorial of zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factoroial result should be "1"