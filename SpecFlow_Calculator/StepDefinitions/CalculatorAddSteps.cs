using SpecFlow_Calculator.Entities;

namespace SpecFlow_Calculator.StepDefinitions {
    [Binding]
    public class CalculatorAddSteps {
        private Calculator Calculator = new Calculator();
        private int numberOne, numberTwo;

        [Given(@"the first element is (.*)")]
        public void GivenTheFirstElementIs(int e1) {
            numberOne = e1;
        }

        [Given(@"the second element is (.*)")]
        public void GivenTheSecondElementIs(int e2) {
            numberTwo = e2;
        }

        [When(@"the two elements are integers")]
        public void WhenElementsAreIntegers() {
            Assert.IsTrue(numberOne == (int)numberOne && numberTwo == (int)numberTwo);
            Calculator.NumberOne = numberOne;
            Calculator.NumberTwo = numberTwo;
        }

        [When(@"the two elements are added")]
        public void WhenTheTwoElementsAreAdded() {
            Assert.AreEqual(Calculator.Add(), (numberOne + numberTwo));
        }

        [Then(@"the addition type should be integer")]
        public void ThenAdditionResultShouldBeInteger() {
            Assert.IsTrue(Calculator.Add() == (int)Calculator.Add());
        }

        [Then(@"the addition result should be equal to (.*)")]
        public void ThenAdditionResultIs(int res) {
            int resAdd = Calculator.Add();
            Assert.AreEqual(res, resAdd);
        }
    }
}
