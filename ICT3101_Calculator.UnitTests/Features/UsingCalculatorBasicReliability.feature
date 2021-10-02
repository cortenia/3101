Feature: UsingCalculatorBasicReliability
 In order to calculate the Basic Musa model's failures/intensities 
 As a Software Quality Metric enthusiast 
 I want to use my calculator to do this

@Reliability 
Scenario: Calculating Current Failure Intensity
  Given I have a calculator 
  When I have entered "10", "50" and "100" into the calculator and press CurrentFailureIntensity 
  Then the Reliability result should be "5.0"

Scenario: Calculating Expected Failure Intensity
  Given I have a calculator 
  When I have entered "100", "10" and "10" into the calculator and press ExpectedFailureIntensity 
  Then the Reliability result should be "63.2"