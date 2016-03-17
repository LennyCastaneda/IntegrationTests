@Chrome
Feature: Paginating GridViews
	Show that pagination controls how many items appear on a page,
	And a user can go to a certain page via a dropdown or arrows.
	
Scenario: Change number of items per page
	Given I open the WorkItems view
	When the Pagination dropdown '5' is selected
	Then the GridView should show '5' rows

Scenario: Select next page
	Given I open the WorkItems view
	When the Pagination dropdown '5' is selected
	And the Pagination Next Page button is clicked
	Then the NewsFeed Pagination Status should read '6-10'

Scenario: Select previous page
	Given I open the WorkItems view
	When the Pagination dropdown '5' is selected
	And the Pagination Next Page button is clicked
	And the Pagination Previous Page button is clicked
	Then the NewsFeed Pagination Status should read '1-5'