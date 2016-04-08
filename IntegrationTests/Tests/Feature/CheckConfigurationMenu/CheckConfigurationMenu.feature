@Chrome
Feature: ConfigurationMenu

Scenario: the ConfigurationMenu is open
	Given Reloaded is open
	When the ConfigurationMenu icon is clicked
	Then the ConfigurationMenu should be visible

Scenario: 'Diary' Configuration is selected
	Given the ConfigurationMenu is open
	When the Configuration 'Diary' is clicked
	And the ConfigurationMenu icon is clicked
	Then the Configuration 'Diary' is active

Scenario: ChooseTheme from Config Menu
	Given the ConfigurationMenu is open
	When the ConfigurationMenu Choose Theme is clicked
	Then the ThemePicker should be visible

Scenario: Save the current Configuration
	Given the ConfigurationMenu is open
	When the ConfigurationMenu Save is clicked
	#Then the Configuration should be saved

Scenario: Save a new Configuration
	Given the ConfigurationMenu is open
	When the ConfigurationMenu Save As is clicked
	#Then the ChooseName Modal should be visible
