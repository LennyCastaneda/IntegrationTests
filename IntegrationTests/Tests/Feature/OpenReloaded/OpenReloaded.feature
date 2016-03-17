@Chrome
Feature: Check Open Reloaded
	In order to go to the home page
	As a user
	I want to open a browser and navigate to 

Scenario: Open Reloaded in Chrome
	Given the Browser exists
	When the Browser is pointed to 'http://dev.durellreloaded.co.uk/'
	And I have logged into Reloaded
	Then the Browser title should be 'Reloaded'