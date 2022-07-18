Feature: Verify all the top navigation menu links are clickable and display content

@tag1
Scenario Outline: Verify the navigation menu Limited time only displays some content
	
	Given I am on myunidays Homepage 
	When I click on a navigation <menu>
	Then a content is displayed

Examples:

	| menu               |
	| Limited time only! |
