using System;
using Xamarin.UITest.Queries;

namespace Appdevcon2017_Demo.Test
{
	public interface IShoppingListScreen
	{
		Func<AppQuery, AppQuery> AddShoppingItemBtn { get; }
	}
}
