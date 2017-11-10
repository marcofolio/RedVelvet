using TechTalk.SpecFlow;
using System;
using Xamarin.UITest;
using System.Reflection;
using System.IO;
using System.Linq;

namespace RedVelvet.Test
{
    public static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(FindApkLocation())
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

        private static string FindApkLocation()
        {
            if (!TestEnvironment.IsTestCloud)
            {
                string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
                var droidProjectDirectory = new FileInfo(currentFile).Directory
                                                        .Parent
                                                        .Parent
                                                        .Parent
                                                        .GetDirectories()
                                                        .Where(s => s.FullName.Contains("Droid"))
                                                        .First();
                var apks = droidProjectDirectory.GetFiles("*.apk", SearchOption.AllDirectories).Where(f => !f.FullName.Contains("obj"));
                return apks.First().FullName;
            }
            else
            {
                return @"net.marcofolio.RedVelvet.apk"; // Select the APK when going to TestCloud
            }
        }
    }
}
