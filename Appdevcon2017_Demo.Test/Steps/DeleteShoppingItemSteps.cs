using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Appdevcon2017_Demo.Test
{
	[Binding]
	public class DeleteShoppingItemSteps : StepsBase
	{
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