using System;
using System.Collections.Generic;
using RedVelvet.Models;
using Xamarin.Forms;

namespace RedVelvet.Views
{
    public partial class ShoppingListPage : ContentPage
    {
        public ShoppingListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = App.Database.GetItems();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingItemPage
            {
                BindingContext = new ShoppingItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ShoppingItemPage
            {
                BindingContext = e.SelectedItem as ShoppingItem
            });
        }
    }
}
