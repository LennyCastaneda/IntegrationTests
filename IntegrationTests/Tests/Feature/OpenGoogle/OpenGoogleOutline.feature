Feature: OpenGoogleOutline

Scenario Outline: Open Google (Outline)
	Given a browser '<browser>'
	When the browser points to 'https://www.google.co.uk/'
	Then the title should be 'Google'

Examples:
	| browser |
	| Chrome  |
	| Edge    |
	| Firefox |