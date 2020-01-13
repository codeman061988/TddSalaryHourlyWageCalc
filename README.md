# TDD Salary, Hourly Wage Calculator
Demonstrates my understanding of **Test Driven Development** through the creation of an app, which calculates Salary and Hourly wages


## Creating our first test case using Red, Green, Refactor

These are stages that we repeat for each unit test case

### Red

[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot.PNG "Screenshot")

Add a failing test first. This makes us confident that our test is going to fail when we expect it to. There is no point in having a test that cannot catch bugs and always passes.

Here we add an initial TestClass to a new solution in Visual Studio

Following the 3 steps of unit testing:

We **arrange** our code by instantiating a new instance of the class which does not exist but we anticipate to perform our business functionality.

We **act** by initializing a new variable of type decimal to hold our annualSalary value, which we declare from an anicipated method called GetAnnualSalary, which takes a decimal as a parameter.

We **assert** that the outcome of GetAnnualSalary will be equal to 104000

We add the expected SalaryCalculator class under a new project so that the project compiles. Still though, we can expect our test to fail because we have not yet added any business logic. All we have done is returned 0 from the method that our test invokes.

Our new class:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot2.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot2.PNG "Screenshot")

Back to the test, our project now compiles but as expected, our test fails:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot3.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RedScreenshot3.PNG "Screenshot")

### Green
Update the failing code in our application so that the test passes:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/GreenScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/GreenScreenshot.PNG "Screenshot")

This would include filling in the blanks which make our testable method return the expected result.

### Refactor
Beautify our code. Remove duplicates, improve the design, make the code easier to read, adhere to coding standards, and the re-run the unit test to make sure it still passes after all of our changes:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RefactorScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/RefactorScreenshot.PNG "Screenshot")

## Creating our second test case, again using Red, Green, Refactor stages

Creating our hourly wage test

### Red

Since our second test case is similar to our first, we simply copied/pasted the first test case and then renamed a few items: 
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRedScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRedScreenshot.PNG "Screenshot")

We add the underlying method that we expect to provide our functionality. We are again in the Red stage; we intentionally have a failing test:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRedScreenshot2.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRedScreenshot2.PNG "Screenshot")

### Green

We build out the method that handles our business logic, returning the anticipated value for our test:
[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondGreenScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondGreenScreenshot.PNG "Screenshot")

### Refactor
To illustrate refactor in this method, we'll just refactor the method using an expression-bodied function member:

[![Screenshot](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRefactorScreenshot.PNG "Screenshot")](https://github.com/codeman061988/TddSalaryHourlyWageCalc/blob/master/docs/SecondRefactorScreenshot.PNG "Screenshot")

As always, we want to be sure our refactor does not affect the functionality, so we just re-run the test again after making the changes.


## Notes on adding tests to an existing project

Even though its the ideal scenario with TDD to write test cases first that drive the design of a program, there are times where we may begin with an existing solution that we need to write test cases for.

### Creating new tests
- Assuming we come into a solution where there are no existing tests, we can start by creating a new test project. Since I personally lean towards monolithic design and naming conventions, this might look something like SolutionName/ProjectName.Tests.
- Once we have a test project set up, we add a Project reference to the project(s) which contain our business logic. Again; from a monolithic design perspective, this would be SolutionName/ProjectName.Core

### Testing existing code
When we test existing code, we are essentially taking the requirements of the project and building tests which check that those requirements are satisfied and then run those tests against the existing code using known I/Os. 
In our test project, we'll make reference to an existing class, create a new instance of that class and then probably create tests against existing methods within that class.