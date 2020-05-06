using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavPrincipal();
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
