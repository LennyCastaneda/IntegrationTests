@Edge
Feature: OpenGoogleInEdge
	In order to browse the web
	As a user
	I want to go to Google using a browser

Scenario: Open Google in Edge
	Given a browser
	When the browser points to 'https://www.google.co.uk/'
	Then the title should be 'Google'
