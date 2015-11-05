@Chrome
Feature: OpenContactManager

Background: 
	Given Reloaded is open
	And the Menu icon is clicked
	When the Menu is open
	And the MenuItem 'Contact Manager' is clicked
	Then the MenuItem 'Contact Manager' is currently expanded

Scenario Outline: Open each Contact Manager tab	
	Given the MenuItem SubItem '<client>' is clicked
	And the Tab '<client>' exists
	Then the Tab '<client>' should be active

Examples: 
	| client             |
	| Individual Clients |
	| Business Clients   |
	| Prospects          |
	| Factfind           |
	| Mailshotting       |
 
