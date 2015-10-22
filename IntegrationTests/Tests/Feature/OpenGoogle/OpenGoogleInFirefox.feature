@Firefox
Feature: OpenGoogleInFirefox
	In order to browse the web
	As a user
	I want to open google in a browser

Scenario: Open Google in Firefox
	Given a browser
	When the browser points to 'https://www.google.co.uk/'
	Then the title should be 'Google'
