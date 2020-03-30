using Syncfusion.XForms.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TravelUiDribble.Views;
using Xamarin.Forms;

namespace TravelUiDribble.ViewModels
{
    class HomeViewModel:MvvmHelpers.BaseViewModel
    {
        public ICommand TappedCommand { get; }
        public HomeViewModel()
        {
            TappedCommand = new Command(Tapped);
        }

        private async void Tapped(object obj)
        {
            var tappedEvent = obj as TappedEventArgs;
            var selectedCardLayout = tappedEvent.Parameter as SfCardView;
            var imagesoure = selectedCardLayout.Content as Image;
            var image = imagesoure.Source;
            var i = image.ToString();
            var filename = i.Split(':')[1];
            var t = filename.Trim();

            await selectedCardLayout.ScaleTo(1.5, 100, Easing.BounceOut);
            await selectedCardLayout.Navigation.PushAsync(new NewItemPage(t));
            await selectedCardLayout.ScaleTo(1, 100);
        }
    }
}
