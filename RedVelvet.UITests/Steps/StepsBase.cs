using System;
using RedVelvet.UITests.Screens;
using RedVelvet.UITests.Screens.ShoppingItem;
using RedVelvet.UITests.Screens.ShoppingList;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace RedVelvet.UITests.Steps
{
    public class StepsBase
    {
        protected readonly IApp app;

        protected readonly IShoppingListScreen shoppingListScreen;
        protected readonly IShoppingItemScreen shoppingItemScreen;

        public StepsBase(FeatureContext featureContext)
        {
            app = featureContext.Get<IApp>("App");

            shoppingListScreen = featureContext.Get<IShoppingListScreen>(ScreenNames.ShoppingList);
            shoppingItemScreen = featureContext.Get<IShoppingItemScreen>(ScreenNames.ShoppingItem);
        }
    }
}
