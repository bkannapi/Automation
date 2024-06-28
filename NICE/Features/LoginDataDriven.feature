Feature: LoginDataDriven

A short summary of the feature

@tag1
Scenario Outline: Login Page Data Driven Testing
	
	Scenario Outline: login with credentials datadriven technique 
    Given I am on nice home page
    When I click the login link
    Then I enter the username "<username>"
    Then  I click the next button
    And I enter the password "<password>"
    And I click the back button
    
    Examples:
      | username      | password      |
      | testuser1     | password1     |
      | testuser2     | password2     |
      | testuser3     | password3     |


	