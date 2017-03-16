using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appdevcon2017_Demo
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
