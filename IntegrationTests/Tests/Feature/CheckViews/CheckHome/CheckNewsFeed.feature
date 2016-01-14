@Chrome
Feature: NewsFeed
	Check the NewsFeed UI works.

Background: 
	Given Reloaded is open
	Then the Tab 'Home' is active

Scenario: Expand a NewsFeed Message
	Given the NewsFeed is visible
	And the NewsFeed Message number '1' is clicked
	When the NewsFeed Message number '1' is expanded
	And the NewsFeed Message number '1' is clicked
	Then the NewsFeed Message number '1' is not expanded

Scenario Outline: Change NewsFeed Options
	Given the NewsFeed is visible
	And the NewsFeed Options is clicked
	Then the NewsFeed Option: '<NewsFeedOption>' is clicked

Examples:
	| NewsFeedOption |
	| Oldest first   |
	| Category       |
	| Title          |
	| Newest first   |

Scenario: Check Pagination Dropdown
	Given the NewsFeed is visible
	And the Pagination dropdown '10' is selected
	Then the Pagination Status should read '1-10 of 16'

Scenario: Check Pagination Next/Previous
	Given the NewsFeed is visible
	And the Pagination dropdown '3' is selected
	When the Pagination Next Page button is clicked
	And the Pagination Previous Page button is clicked
	Then the Pagination Status should read '1-3 of 16'	