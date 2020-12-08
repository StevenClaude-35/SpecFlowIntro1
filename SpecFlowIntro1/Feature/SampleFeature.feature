Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create a new Employee with mandatary details
	#Given I have opened my application
	#Then  I should see employee details page
	When I fill all the mandatory details in form
	| Name   | Age | Phone    | Email           |
	| Claude | 40  | 12345678 | claude@yahoo.fr |
	| Raphael | 2  | 12345670 | raphael@yahoo.fr |
	| David   | 39  | 12345672 | david@yahoo.fr |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new Employee with mandatary details for different iteration
	#Given I have opened my application
	#Then  I should see employee details page
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples:
		| Name   | Age | Phone     | 
	    | Claude | 40  | 12345678  |
	    | Raphael | 2  | 12345670  |
	    | David   | 39  | 12345672 | 