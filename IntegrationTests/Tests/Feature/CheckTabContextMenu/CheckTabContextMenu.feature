@Chrome
Feature: CheckTabContextMenu

Scenario: ContextMenu Reload
	Given the Tab ContextMenu is visible
	When the Tab ContextMenu Reload is clicked
	#Then the View should be loading #Doesn't take long enough to reload to catch it in the act!

Scenario: ContextMenu Duplicate
	Given the Tab ContextMenu is visible
	When the Tab ContextMenu Duplicate is clicked
	Then the Tab count should be '3'

Scenario: ContextMenu CloseTab
	Given the Tab ContextMenu is visible
	When the Tab ContextMenu CloseTab is clicked
	Then the Tab 'Work Items' should not be visible

Scenario: ContextMenu CloseTabsToRight
	Given the Tab ContextMenu is visible
	When the Tab 'Home' is right-clicked
	And the Tab ContextMenu CloseTabsToRight is clicked
	Then the Tab count should be '1'
	And the Tab 'Home' should be active