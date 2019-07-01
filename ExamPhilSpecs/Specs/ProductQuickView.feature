Feature: ProductQuickView
	Test the functionality of Product Quick View


@Browser:Chrome
Scenario: Click over the Product Image
	When I click over the Image of any product
	Then the system will display a window with options about the product
