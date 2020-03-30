using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelUiDribble.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelUiDribble.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public string i { get; set; }
        public NewItemPage(string imageSource)
        {
            InitializeComponent();
            var i = imageSource;
            BindingContext = new NewItemViewModel(i);
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}