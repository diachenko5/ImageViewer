Feature: Logout
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](ImageViewer/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@regrestion @smoke
Scenario: Success logout 
	Given I enter code and password
		| code       | password   |
		| "333333"   | "333333"   |
	When click Log in
	Then I am authorized to the app
	And click Logout
	Then I am not authorized to the app


