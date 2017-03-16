﻿using System;
using Xamarin.UITest.Queries;

namespace Appdevcon2017_Demo.Test
{
	public interface IShoppingItemScreen
	{
		Func<AppQuery, AppQuery> ItemNameEntry { get; }
		Func<AppQuery, AppQuery> BoughtToggle { get; }
		Func<AppQuery, AppQuery> SaveItemBtn { get; }
		Func<AppQuery, AppQuery> DeleteItemBtn { get; }
		Func<AppQuery, AppQuery> CancelItemBtn { get; }
	}
}
