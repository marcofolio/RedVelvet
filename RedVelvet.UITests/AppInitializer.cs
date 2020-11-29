using System;
using System.IO;
using System.Reflection;
using RedVelvet.UITests.Screens;
using RedVelvet.UITests.Screens.ShoppingItem;
using RedVelvet.UITests.Screens.ShoppingList;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using System.Linq;

namespace RedVelvet.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            throw new ArgumentException("Unsupported platform");
        }

        public static void InitializeScreens(Platform platform)
        {
            if (platform == Platform.Android)
            {
                FeatureContext.Current.Add(ScreenNames.ShoppingList, new AndroidShoppingListScreen());
                FeatureContext.Current.Add(ScreenNames.ShoppingItem, new AndroidShoppingItemScreen());
            }
            else
            {
                throw new ArgumentException("Unsupported platform");
            }
        }
    }
}