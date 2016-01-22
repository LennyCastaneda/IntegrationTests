Feature: Browsers open Google
	Check that the webdrivers are working at a minimum level by opening Google.co.uk in each.
	This test is provided to simply check each supported browser can be run. 

Scenario Outline: Check Browsers open Google
	Given the Browser '<browser>'
	When the Browser is pointed to 'https://www.google.co.uk/'
	Then the Browser title should be 'Google'

Examples:
	| browser |
	| Chrome  |
	#| Edge    |
	#| Firefox |
	#| IE32    |
	#| IE64    |