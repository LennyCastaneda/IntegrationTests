@Chrome
Feature: Check Open Reloaded
	In order to go to the home page
	As a user
	I want to open a browser and navigate to 

Scenario: Open Reloaded in Chrome
	Given the Browser exists
	#When the Browser is pointed to 'http://durell.co.uk:1024/#/config/1'
	When the Browser is pointed to 'http://localhost:52755/index.html'
	Then the Browser title should be 'Reloaded'