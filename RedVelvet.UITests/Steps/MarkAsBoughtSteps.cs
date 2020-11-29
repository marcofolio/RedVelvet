using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace RedVelvet.UITests.Steps
{
    [Binding]
    public class MarkAsBoughtSteps : StepsBase
    {
        public MarkAsBoughtSteps(FeatureContext featureContext)
            : base (featureContext)
        {

        }

        [When(@"I press as bought")]
        public void IPressAsBought()
        {
            app.WaitForElement(shoppingItemScreen.BoughtToggle);
            app.Tap(shoppingItemScreen.BoughtToggle);
        }

        [Then(@"I should see ""(.*)"" marked as (.*) in my shopping list")]
        public void ThenIShouldSeeItemMarkedAsStateInMyShoppingList(string name, string state)
        {
            var expectedState = state.ToLowerInvariant().Equals("bought") ? true : false;
            var bougth = app.Query(x => x.Marked(name).Parent().Class("ViewCellRenderer_ViewCellContainer").Child().Class("ImageRenderer")).Length == 2;

            Assert.AreEqual(expectedState, bougth);
        }
    }
}
