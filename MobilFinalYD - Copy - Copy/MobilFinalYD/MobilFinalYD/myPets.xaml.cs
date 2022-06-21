using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilFinalYD.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilFinalYD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pets : ContentPage
    {
        public Pets()
        {
            InitializeComponent();
            lvProperties.ItemsSource = Repo.Pets;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new petDetail());
        }

        async void addPetCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addPetPage());
        }
    }
}