﻿Feature: Login
	Check if the Login functionality is working
	as expected with different permutations and
	combinations of data

Background: 
	Given I Delete employee 'AutoUser' before I start running test

@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigated to the application
	And I see application opened
	Then I click login link
	When I enter UserName and Password
	| UserName | Password |
	| admin    | password |
	Then I click login button
	Then I should see the username with hello