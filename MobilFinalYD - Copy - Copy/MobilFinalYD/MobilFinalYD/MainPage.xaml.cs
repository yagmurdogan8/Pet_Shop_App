using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilFinalYD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async void DogClick(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pets(), true);
        }

        async void myPets_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pets());
        }
        async void shop_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shopPage());

        }
        async void myProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new myProfilePage());

        }
        async void expenses_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new expenses());

        }
    }
}
