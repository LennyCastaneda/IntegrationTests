@Chrome
Feature: All Records 
	Show that the gridview "All Records" can be opened.

Scenario: Viewing all WorkItems
	Given I open the WorkItems view
	Then I should see a list of WorkItems