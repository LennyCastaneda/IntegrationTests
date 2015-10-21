@Chrome
Feature: OpenHomePage
	In order to ensure the website works
	As a user
	I want to goto the website using a browser

Scenario: Open the index in a browser
	Given a browser
	When it points to 'https://www.google.co.uk/'
	Then the title should be 'Google'
