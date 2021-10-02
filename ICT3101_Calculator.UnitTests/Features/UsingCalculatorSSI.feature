Feature: UsingCalculatorSSI
  In order to calculate SSI 
  As someone who struggles with math 
  I want to be able to use my calculator to do this 
 
@SSI 
Scenario: Calculating SSI 
  Given I have a calculator 
  When I have entered "50", "20" and "4" into the calculator and press SSI 
  Then the SSI result should be "66" 
  