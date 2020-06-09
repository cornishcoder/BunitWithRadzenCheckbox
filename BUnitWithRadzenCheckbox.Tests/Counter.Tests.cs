using Bunit;
using BUnitWithRadzenCheckbox.Pages;
using Xunit;

namespace BUnitWithRadzenCheckbox.Tests
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void ClickMeButtonDisabledWhenCheckboxChecked()
        {
            // Arrange
            var cut = RenderComponent<Counter>();
            //cut.Find("#checkBox1").Click();

            // Act
            cut.Find("#button").Click();

            // Assert
            cut.Find("#currentCount").MarkupMatches("<p id=\"currentCount\">Current count: 0</p>");
        }
    }
}
