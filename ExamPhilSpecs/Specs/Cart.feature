Feature: Cart
	Test the Functionality of Add products in the Cart

@Browser:Chrome
Scenario: Add a product
	Given I click on the button <Add to cart> of any product
	Then the application will show a window with the message <Product successfully added to your shopping cart>
