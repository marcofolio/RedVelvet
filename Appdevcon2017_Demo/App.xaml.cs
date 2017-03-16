using Xamarin.Forms;

namespace Appdevcon2017_Demo
{
	public partial class App : Application
	{
		static ShoppingItemDatabase database;

		public App()
		{
			InitializeComponent();

			Resources = new ResourceDictionary();
			Resources.Add("primaryRed", Color.FromHex("b51919"));

			var nav = new NavigationPage(new ShoppingListPage());
			nav.BarBackgroundColor = (Color)App.Current.Resources["primaryRed"];
			nav.BarTextColor = Color.White;

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
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
