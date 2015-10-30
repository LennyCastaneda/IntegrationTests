Feature: OpenGoogleOutline

Scenario Outline: Open Google (Outline)
	Given the Browser '<browser>'
	When the Browser is pointed to 'https://www.google.co.uk/'
	Then the Browser title should be 'Google'


Examples:
	| browser |
	| Chrome  |
	| Edge    |
	| Firefox |