@Chrome
Feature: OpenGoogleInChrome
	In order to ensure the website works
	As a user
	I want to goto the website using a browser

Scenario: Open Google in Chrome
	Given a browser
	When the browser points to 'https://www.google.co.uk/'
	Then the title should be 'Google'
