Feature: SignIn
	Test the register functionality of application
	Will verify the register of a new user on the application

@Browser:Firefox
Scenario: Create a New User
	Given I have navigated to the application
	And I click on the Link <Sign In>
	And I type a valid e-mail
		| e-mail             |
		| testeinbev@bev.com |
	And I click on the Button <Create an account>
	Then The system will show the User Personal Information Form
	Given I Fullfill the required fields with valid data
		| First name | Last name | Email              | Password | Date of Birth | Company | Address   | City        | State  | Zip/Postal Code | Mobile Phone  | Assign an address alias for future reference |
		| name       | Last      | testeinbev@bev.com | 11345    | 21            | teste   | Rua do QA | El Salvador | Kansas | 86367           | 5577988554423 | Testando                                     |  
	When I click on <Register> Button
	Then A new User will be created