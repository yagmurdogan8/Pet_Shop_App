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
    public partial class expenses : ContentPage
    {
        public expenses()
        {
            InitializeComponent();
            lvIncomeAndExpenses.ItemsSource = Repo.IncomeAndExpenses;
        }

        async void AddExpenseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addExpense());
        }
    }
}