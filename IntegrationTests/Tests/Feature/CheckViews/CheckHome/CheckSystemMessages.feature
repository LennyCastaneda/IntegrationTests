@Chrome
Feature: SystemMessages
	Check the System Messages UI works.

Background: 
	Given Reloaded is open
	Then the Tab 'Home' should be active

Scenario: Expand a System Message
	Given the SystemMessages feed is visible
	And the SystemMessages Message number '1' is clicked
	When the SystemMessages Message number '1' is expanded
	And the SystemMessages Message number '1' is clicked
	Then the SystemMessages Message number '1' is not expanded