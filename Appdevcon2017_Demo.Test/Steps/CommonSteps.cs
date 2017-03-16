using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Appdevcon2017_Demo.Test
{
	[Binding]
	public class CommonSteps
	{
		readonly IApp app;

		readonly IShoppingListScreen shoppingListScreen;
		readonly IShoppingItemScreen shoppingItemScreen;

		public CommonSteps()
		{
			app = FeatureContext.Current.Get<IApp>("App");

			shoppingListScreen = FeatureContext.Current.Get<IShoppingListScreen>(ScreenNames.ShoppingList);
			shoppingItemScreen = FeatureContext.Current.Get<IShoppingItemScreen>(ScreenNames.ShoppingItem);
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
