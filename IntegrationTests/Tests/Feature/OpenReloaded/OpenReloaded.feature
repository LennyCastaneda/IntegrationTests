@Chrome
Feature: OpenReloaded
	In order to go to the home page
	As a user
	I want to open a browser and navigate

Scenario: Open Reloaded in Chrome
	Given a browser
	When the browser points to 'http://durell.co.uk:1024/#/config/1'
	Then the title should be 'Reloaded'
