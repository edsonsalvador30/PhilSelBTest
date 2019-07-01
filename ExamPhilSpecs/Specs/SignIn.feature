Feature: SignIn
	Test the register functionality of application
	Will verify the register of a new user on the application

@Browser:Chrome
Scenario: Create a New User
	Given I have navigated to the application
	And I click on the Link <Sign In>
	And I type a valid e-mail
	And I click on the Button <Create an account>
	Then The system will show the User Personal Information Form
	Given I Fullfill the required fields with valid data
	When I click on <Register> Button
	Then A new User will be created

Examples: 
| e-mail | Title | First name | Last name | Email | Password | Date of Birth | Company | Address |
|        |       |            |           |       |          |               |         |         | 

Examples: 
| City | State | Zip/Postal Code | Mobile Phone | Assign an address alias for future reference |
|      |       |                 |              |                                              | 