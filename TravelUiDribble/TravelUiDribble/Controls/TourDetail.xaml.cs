using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelUiDribble.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TourDetail : StackLayout
    {
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(TourDetail), string.Empty);
        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly BindableProperty NameSourceProperty = BindableProperty.Create(nameof(NameSource), typeof(string), typeof(TourDetail), string.Empty);
        public string NameSource
        {
            get { return (string)GetValue(NameSourceProperty); }
            set { SetValue(NameSourceProperty, value); }
        }

        public static readonly BindableProperty AirportNameSourceProperty = BindableProperty.Create(nameof(AirportNameSource), typeof(string), typeof(TourDetail), string.Empty);
        public string AirportNameSource
        {
            get { return (string)GetValue(AirportNameSourceProperty); }
            set { SetValue(AirportNameSourceProperty, value); }
        }

        public static readonly BindableProperty PriceSourceProperty = BindableProperty.Create(nameof(PriceSource), typeof(string), typeof(TourDetail), string.Empty);
        public string PriceSource
        {
            get { return (string)GetValue(PriceSourceProperty); }
            set { SetValue(PriceSourceProperty, value); }
        }

        public static readonly BindableProperty DaysSourceProperty = BindableProperty.Create(nameof(DaysSource), typeof(string), typeof(TourDetail), string.Empty);
        public string DaysSource
        {
            get { return (string)GetValue(DaysSourceProperty); }
            set { SetValue(DaysSourceProperty, value); }
        }


        public TourDetail()
        {
            InitializeComponent();
        }
    }
}