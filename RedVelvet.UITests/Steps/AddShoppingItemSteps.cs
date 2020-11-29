using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace RedVelvet.UITests.Steps
{
    [Binding]
    public class AddShoppingItemSteps : StepsBase
    {
        public AddShoppingItemSteps(FeatureContext featureContext)
            : base(featureContext)
        {

        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            app.Tap(shoppingListScreen.AddShoppingItemBtn);
        }

        [When(@"I enter the name ""(.*)""")]
        public void IEnterTheName(string name)
        {
            app.WaitForElement(shoppingItemScreen.ItemNameEntry);
            app.ClearText(shoppingItemScreen.ItemNameEntry);
            app.EnterText(shoppingItemScreen.ItemNameEntry, name);
        }

        [Then(@"I should see ""(.*)"" in my shopping list")]
        public void ThenIShouldSeeInMyShoppingList(string name)
        {
            app.WaitForElement(shoppingListScreen.AddShoppingItemBtn);
            app.ScrollDownTo(c => c.Marked(name));
            var result = app.Query(c => c.Marked(name)).Length;
            Assert.AreEqual(1, result);
        }
    }
}
