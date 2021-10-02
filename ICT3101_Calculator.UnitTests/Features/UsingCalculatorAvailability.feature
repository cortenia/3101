Feature: UsingCalculatorAvailability 
  In order to calculate MTBF and Availability 
  As someone who struggles with math 
  I want to be able to use my calculator to do this 
 
@Availability 
Scenario: Calculating MTBF 
  Given I have a calculator 
  When I have entered "20" and "20" into the calculator and press MTBF 
  Then the availability result should be "40" 
 
@Availability 
Scenario: Calculating Availability 
  Given I have a calculator 
  When I have entered "20" and "40" into the calculator and press Availability 
  Then the availability result should be "0.5"

@Availability 
Scenario: Calculating Availability in percentage
  Given I have a calculator 
  When I have entered "0.5" and "100"% into the calculator and press Availability 
  Then the availability result should be "50.0"