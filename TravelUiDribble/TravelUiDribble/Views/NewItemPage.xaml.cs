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
        NewItemViewModel viewModel = new NewItemViewModel();
        public string i { get; set; }
        public NewItemPage(string imageSource)
        {
            InitializeComponent();
            i = imageSource;
            BindingContext = viewModel;
            LabelInfo();
        }

        private void LabelInfo()
        {
            
            switch (i)
            {
                case "lake.png":
                    viewModel.Name = i;
                    nameLabel.Text = "Lake";
                    break;
                case "mountain.png":
                    viewModel.Name = i;
                    nameLabel.Text = "Mountain";
                    break;
                case "valley.png":
                    viewModel.Name = i;
                    nameLabel.Text = "Valley";
                    break;

                default:
                    // code block
                    break;
            }
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}