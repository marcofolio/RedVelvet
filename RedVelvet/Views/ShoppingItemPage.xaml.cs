using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedVelvet
{
    public partial class ShoppingItemPage : ContentPage
    {
        public ShoppingItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var shoppingItem = (ShoppingItem)BindingContext;
            App.Database.SaveItem(shoppingItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var shoppingItem = (ShoppingItem)BindingContext;
            App.Database.DeleteItem(shoppingItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
