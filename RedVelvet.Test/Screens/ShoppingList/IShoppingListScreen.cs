using System;
using Xamarin.UITest.Queries;

namespace RedVelvet.Test
{
    public interface IShoppingListScreen
    {
        Func<AppQuery, AppQuery> AddShoppingItemBtn { get; }
    }
}
