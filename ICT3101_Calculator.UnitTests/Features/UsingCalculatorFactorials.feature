Feature: UsingCalculatorFactorials
		In order to conquer Factorials
		As a Factorial enthusiast
		I want to capture all the Factorials and be the best that no one has

@Factorials 
Scenario: Factorial of positive number
 Given I have a calculator 
 When I have entered "4" into the calculator and press Factorial 
 Then the factorial result should be "24" 
 
@Factorials 
Scenario: Factorial of zero
 Given I have a calculator 
 When I have entered "0" into the calculator and press Factorial 
 Then the factorial result should be "1"
 
