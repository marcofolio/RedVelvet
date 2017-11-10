using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RedVelvet
{
    public class ShoppingItemDatabase
    {
        private int currentId = 1;
        private ObservableCollection<ShoppingItem> _shoppingItems;

        public ShoppingItemDatabase()
        {
            _shoppingItems = new ObservableCollection<ShoppingItem>();

            // Initial demo data
            // http://www.jamieoliver.com/news-and-features/features/how-to-make-red-velvet-cake/
            SaveItem(new ShoppingItem() { Name = "250g plain flour" });
            SaveItem(new ShoppingItem() { Name = "40g cocoa powder" });
            SaveItem(new ShoppingItem() { Name = "100ml ketchup" });
            SaveItem(new ShoppingItem() { Name = "240ml vegetable oil" });
            SaveItem(new ShoppingItem() { Name = "300g granulated sugar", Bought = true });
            SaveItem(new ShoppingItem() { Name = "2 large free-range eggs" });
            SaveItem(new ShoppingItem() { Name = "tablespoon white wine vinegar" });
            SaveItem(new ShoppingItem() { Name = "240ml buttermilk" });
            SaveItem(new ShoppingItem() { Name = "175g unsalted butter" });
            SaveItem(new ShoppingItem() { Name = "400g icing sugar", Bought = true });
            SaveItem(new ShoppingItem() { Name = "300g full-fat cream cheese" });
        }

        public ObservableCollection<ShoppingItem> GetItems()
        {
            return _shoppingItems;
        }

        public void SaveItem(ShoppingItem item)
        {
            if (item.ID != 0)
            {
                var itemInList = _shoppingItems.First(x => x.ID == item.ID);
                var index = _shoppingItems.IndexOf(itemInList);
                if (index != -1)
                {
                    _shoppingItems[index] = item;
                }
            }
            else
            {
                item.ID = currentId;
                _shoppingItems.Add(item);
                currentId++;
            }
        }

        public void DeleteItem(ShoppingItem item)
        {
            _shoppingItems.Remove(item);
        }
    }
}
