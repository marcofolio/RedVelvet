using System;
using Xamarin.UITest.Queries;

namespace RedVelvet.UITests.Screens.ShoppingItem
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
