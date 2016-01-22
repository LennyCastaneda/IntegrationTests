@Chrome
Feature: SystemMessages
	Check the System Messages UI works.

Scenario: Expand a System Message
	Given the 'Home' Tab is open
	When the SystemMessages Message number '1' is clicked
	Then the SystemMessages Message number '1' is expanded

Scenario: Un-Expand a System Message
	Given the 'Home' Tab is open
	When the SystemMessages Message number '1' is clicked
	Then the SystemMessages Message number '1' is expanded
	When the SystemMessages Message number '1' is clicked
	Then the SystemMessages Message number '1' is not expanded