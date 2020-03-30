using System;
using System.Collections.Generic;
using System.Text;

namespace TravelUiDribble.ViewModels
{
    class NewItemViewModel : MvvmHelpers.BaseViewModel
    {
        private string _someImage;
        public string SomeImage
        {
            get { return _someImage; }
            set
            {
                _someImage = value;
                OnPropertyChanged(nameof(SomeImage));
            }
        }

        public NewItemViewModel(string i)
        {

            SomeImage = i;
            //selectedCardLayout.ScaleTo(2,2000,Easing.BounceOut); 
        }
    }
}
