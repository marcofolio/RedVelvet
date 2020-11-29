using System;
using Xamarin.UITest.Queries;

namespace RedVelvet.UITests.Screens.ShoppingItem
{
    public class AndroidShoppingItemScreen : IShoppingItemScreen
    {
        public Func<AppQuery, AppQuery> ItemNameEntry { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("ItemName"));

        public Func<AppQuery, AppQuery> BoughtToggle { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("BoughtToggle"));

        public Func<AppQuery, AppQuery> SaveItemBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("Save"));

        public Func<AppQuery, AppQuery> DeleteItemBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("Delete"));

        public Func<AppQuery, AppQuery> CancelItemBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Marked("Cancel"));
    }
}
