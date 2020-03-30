using System;
using System.Collections.Generic;
using System.Text;

namespace TravelUiDribble.ViewModels
{
    class NewItemViewModel : MvvmHelpers.BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public NewItemViewModel()
        {

            
            //selectedCardLayout.ScaleTo(2,2000,Easing.BounceOut); 
        }

        //public NewItemViewModel()
        //{
        //}
    }
}
