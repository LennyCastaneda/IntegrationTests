@Chrome
Feature: Check NewsFeed
	Check the NewsFeed UI works.

Scenario: the 'Home' Tab is open
	Given the Menu is open
	When the Menu item 'Home' is clicked
	Then the Tab 'Home' should be active

Scenario: Expand a NewsFeed Message
	Given the 'Home' Tab is open
	When the NewsFeed Message number '1' is clicked
	And the NewsFeed Message number '1' is clicked
	Then the NewsFeed Message number '1' is not expanded

Scenario Outline: Change NewsFeed Filters
	Given the 'Home' Tab is open
	When the NewsFeed Filter Icon is clicked
	And the NewsFeed Filter: '<NewsFeedOption>' is clicked
	#Then the NewsFeed is ordered by '<NewsFeedOption>'

Examples:
	| NewsFeedOption |
	| Oldest first   |
	| Category       |
	| Title          |
	| Newest first   |

Scenario: Check Pagination Dropdown
	Given the 'Home' Tab is open
	When the NewsFeed Pagination dropdown '10' is selected
	Then the NewsFeed Pagination Status should read '1-10'

Scenario: Check Pagination Next/Previous
	Given the 'Home' Tab is open
	When the NewsFeed Pagination dropdown '3' is selected
	When the NewsFeed Pagination Next Page button is clicked
	And the NewsFeed Pagination Previous Page button is clicked
	Then the NewsFeed Pagination Status should read '1-3'