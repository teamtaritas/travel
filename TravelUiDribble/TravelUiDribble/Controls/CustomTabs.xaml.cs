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
    public partial class CustomTabs : Grid
    {
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(CustomTabs), string.Empty);
        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly BindableProperty TabsLabelProperty = BindableProperty.Create(nameof(TabsLabel), typeof(string), typeof(CustomTabs), string.Empty);
        public string TabsLabel
        {
            get { return (string)GetValue(TabsLabelProperty); }
            set { SetValue(TabsLabelProperty, value); }
        }

        public static readonly BindableProperty TabsLabelColorProperty = BindableProperty.Create(nameof(TabsLabelColor), typeof(Color), typeof(CustomTabs), Color.Transparent);
        public Color TabsLabelColor
        {
            get { return (Color)GetValue(TabsLabelColorProperty); }
            set { SetValue(TabsLabelColorProperty, value); }
        }

        public CustomTabs()
        {
            InitializeComponent();
        }
    }
}