using Onlykitchen.Services;
using Onlykitchen.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Onlykitchen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage( new Login());
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
