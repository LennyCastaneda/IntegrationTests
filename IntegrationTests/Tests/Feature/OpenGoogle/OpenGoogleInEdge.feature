Feature: OpenGoogleInEdge
	In order to browse the web
	As a user
	I want to go to Google using a browser

Scenario: Open Google in Edge
	Given the Browser 'Edge'
	When the Browser is pointed to 'https://www.google.co.uk/'
	Then the Browser title should be 'Google'