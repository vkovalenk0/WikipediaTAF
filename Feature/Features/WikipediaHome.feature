Feature: Ability to see Wikipedia home page

@mytag
Scenario: Verify link on the home page contains Wikipedia
	When Users opens home page
	Then Home page link contains text 'Wikipedia'