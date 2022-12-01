Feature: TMfeature

As a TurnUp portal admin
I would like to create edit delete time and material page
so that i can manage employee details


Scenario: Create time and materials with valid data
	Given  I logged into turnup portal
	When I navigated to time and material page
	And  I create a time and material record
	Then The record should be createdsuccessfully

Scenario Outline: Edit existing time record with valid details
Given I logged into turnup portal
When I navigated to time and material page
And I update '<Description>' on an existing time record
Then The record should have been updated '<Description>'

Examples:
| Description  |
| Time         |
| Material     |
| EditedRecord |




