Feature: UsingCalculatorLogReliability
  In order to calculate Log Musa Reliability
  As someone who struggles with math 
  I want to be able to use my calculator to do this 
 
@Density 
Scenario: Calculating Log Current Failure Intensity
  Given I have a calculator 
  When I have entered "10.0", "0.02" and "50.0" into the calculator and press Log 
  Then the Log Reliability result should be "3.7" 
 