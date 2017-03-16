using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Appdevcon2017_Demo.Test
{
	[Binding]
	public class AddShoppingItemSteps : StepsBase
	{
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
