using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace RedVelvet.UITests.Steps
{
    [Binding]
    public class DeleteShoppingItemSteps : StepsBase
    {
        public DeleteShoppingItemSteps(FeatureContext featureContext)
            : base(featureContext)
        {

        }

        [When(@"I press delete")]
        public void WhenIPressDelete()
        {
            app.WaitForElement(shoppingItemScreen.DeleteItemBtn);
            app.Tap(shoppingItemScreen.DeleteItemBtn);
        }

        [Then(@"I should not see ""(.*)"" in my shopping list")]
        public void ThenIShouldNotSeeInMyShoppingList(string name)
        {
            var result = app.Query(c => c.Marked(name)).Length;
            Assert.AreEqual(0, result);
        }
    }
}
