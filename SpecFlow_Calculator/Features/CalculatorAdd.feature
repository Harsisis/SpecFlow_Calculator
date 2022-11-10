Feature: CalculatorAdd

A short summary of the feature

@tag1
Scenario: Verify two entries and add them if they are numbers
	Given the first element is 50
	And the second element is 70
	When the two elements are integers
	And the two elements are added
	Then the addition type should be integer
	And the addition result should be equal to 120
