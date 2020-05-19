using appUbicua1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appUbicua1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PagosPage());
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
