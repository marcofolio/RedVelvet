using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace RedVelvet.UITests
{
    public class FeatureBase
    {
        protected static IApp app;
        protected Platform platform;

        public FeatureBase()
        {
            this.platform = Platform.Android;
        }

        [TestInitialize]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            FeatureContext.Current.Clear();
            FeatureContext.Current.Add("App", app);
            AppInitializer.InitializeScreens(platform);
        }
    }
}
