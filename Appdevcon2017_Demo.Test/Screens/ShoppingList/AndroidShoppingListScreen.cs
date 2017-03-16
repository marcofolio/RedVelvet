using System;
using Xamarin.UITest.Queries;

namespace Appdevcon2017_Demo.Test
{
	public class AndroidShoppingListScreen : IShoppingListScreen
	{
		public Func<AppQuery, AppQuery> AddShoppingItemBtn { get; } =
			new Func<AppQuery, AppQuery>(c => c.Marked("+"));
	}
}
