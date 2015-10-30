@Firefox
Feature: OpenGoogleInFirefox
	In order to browse the web
	As a user
	I want to open google in a browser

Scenario: Open Google in Firefox
	Given the Browser exists
	When the Browser is pointed to 'https://www.google.co.uk/'
	Then the Browser title should be 'Google'
