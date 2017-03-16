using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Appdevcon2017_Demo.Test
{
	[Binding]
	public class MarkAsBoughtSteps : StepsBase
	{
		[When(@"I press as bought")]
		public void IPressAsBought()
		{
			app.WaitForElement(shoppingItemScreen.BoughtToggle);
			app.Tap(shoppingItemScreen.BoughtToggle);
		}

		[Then(@"I should see ""(.*)"" marked as (.*) in my shopping list")]
		public void ThenIShouldSeeItemMarkedAsStateInMyShoppingList(string name, int state)
		{
			var expectedState = state == 0 ? false : true;
			var bougth = app.Query(x => x.Marked(name).Parent().Class("ViewCellRenderer_ViewCellContainer").Child().Class("ImageRenderer")).Length == 2;

			Assert.AreEqual(expectedState, bougth);
		}
	}
}