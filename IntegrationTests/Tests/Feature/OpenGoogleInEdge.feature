@Edge
Feature: OpenGoogleInEdgefeature
	In order to browse the web
	As a user
	I want to go to Google using a browser

Scenario: Open the index in a browser
	Given a browser
	When the browser points to 'https://www.google.co.uk/'
	Then the title should be 'Google'
