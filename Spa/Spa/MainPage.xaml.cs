using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Spa
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BtnTalleres_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPrincipal());

        }

        async void BtnInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavInfo());
        }

        async void BtnTips_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavTips());
        }
    }
}
