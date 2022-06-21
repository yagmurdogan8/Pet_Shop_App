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
    public partial class shopPage : ContentPage
    {
        public shopPage()
        {
            InitializeComponent();
            lvProducts.ItemsSource = Repo.Pets;
        }
    }
}