@Chrome
Feature: Save Config As
	Show that a new configuration can be created with a user defined name.

Scenario: Save Configuration As
	Given the ConfigurationMenu is open
	When the ConfigurationMenu Save As is clicked
	And I enter the name 'New Configuration' into the SaveAs modal
	And I click Save in the SaveAs modal
	And I open the Configuration Menu
	Then the Configuration 'New Configuration' should exist