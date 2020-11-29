using System;
using Xamarin.UITest.Queries;

namespace RedVelvet.UITests.Screens.ShoppingList
{
    public class AndroidShoppingListScreen : IShoppingListScreen
    {
        public Func<AppQuery, AppQuery> AddShoppingItemBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("+"));
    }
}
