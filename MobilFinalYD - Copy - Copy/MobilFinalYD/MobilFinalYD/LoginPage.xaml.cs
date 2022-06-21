using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilFinalYD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void RegisterCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        async void LoginCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new myProfilePage());
        }
    }
}