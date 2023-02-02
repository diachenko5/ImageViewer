Feature: PictureViewScreen
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](ImageViewer/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@regrestion @smoke
Scenario: Verify presence of elements 
	Given I enter code and password
		| code       | password   |
		| "333333"   | "333333"   |
	When click Log in
	Then id element is present
	And picture is present
	Then slider is present

	#SPEC doesn't say but i guess that id is increased every time when i'm login, let's check it also
@regrestion @smoke
Scenario: Verify increase id number 
	Given I enter code and password
		| code       | password   |
		| "333333"   | "333333"   |
	When click Log in
	And remember id number
	And click Logout
	And Enter code and password
		| code       | password   |
		| "333333"   | "333333"   |
	Then id number should increase


