using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace RedVelvet.Test
{
    public class StepsBase
    {
        protected readonly IApp app;

        protected readonly IShoppingListScreen shoppingListScreen;
        protected readonly IShoppingItemScreen shoppingItemScreen;

        public StepsBase()
        {
            app = FeatureContext.Current.Get<IApp>("App");

            shoppingListScreen = FeatureContext.Current.Get<IShoppingListScreen>(ScreenNames.ShoppingList);
            shoppingItemScreen = FeatureContext.Current.Get<IShoppingItemScreen>(ScreenNames.ShoppingItem);
        }
    }
}
