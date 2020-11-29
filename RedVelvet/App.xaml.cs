using System;
using RedVelvet.Data;
using RedVelvet.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedVelvet
{
    public partial class App : Application
    {
        static ShoppingItemDatabase database;

        public App()
        {
            InitializeComponent();

            Resources = new ResourceDictionary
            {
                { "primaryRed", Color.FromHex("b51919") }
            };

            var nav = new NavigationPage(new ShoppingListPage())
            {
                BarBackgroundColor = (Color)App.Current.Resources["primaryRed"],
                BarTextColor = Color.White
            };

            MainPage = nav;
        }

        public static ShoppingItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingItemDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
