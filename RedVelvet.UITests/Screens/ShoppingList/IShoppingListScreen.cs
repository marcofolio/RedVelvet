using System;
using Xamarin.UITest.Queries;

namespace RedVelvet.UITests.Screens.ShoppingList
{
    public interface IShoppingListScreen
    {
        Func<AppQuery, AppQuery> AddShoppingItemBtn { get; }
    }
}
