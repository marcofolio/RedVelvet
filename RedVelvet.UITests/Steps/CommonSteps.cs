using System;
using RedVelvet.UITests.Screens;
using RedVelvet.UITests.Screens.ShoppingItem;
using RedVelvet.UITests.Screens.ShoppingList;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace RedVelvet.UITests.Steps
{
    [Binding]
    public class CommonSteps
    {
        readonly IApp app;

        readonly IShoppingListScreen shoppingListScreen;
        readonly IShoppingItemScreen shoppingItemScreen;

        public CommonSteps(FeatureContext featureContext)
        {
            app = featureContext.Get<IApp>("App");

            shoppingListScreen = featureContext.Get<IShoppingListScreen>(ScreenNames.ShoppingList);
            shoppingItemScreen = featureContext.Get<IShoppingItemScreen>(ScreenNames.ShoppingItem);
        }

        [Given(@"I have items in my shopping list")]
        public void IHaveItemsInMyShoppingList()
        {
            // Implicit
        }

        [When(@"I edit ""(.*)""")]
        public void WhenIEdit(string name)
        {
            app.Tap(c => c.Marked(name));
        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            app.WaitForElement(shoppingItemScreen.SaveItemBtn);
            app.Tap(shoppingItemScreen.SaveItemBtn);
        }
    }
}
