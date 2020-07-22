using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace angl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class second : ContentPage
    {
        public second()
        {
            InitializeComponent();

            ToolbarItem sav = new ToolbarItem
            {
                IconImageSource = "safe.png",
                Priority=2,
            };

            ToolbarItems.Add(sav);


            Uri uri = new Uri("https://www.really-learn-english.com/adapt-vs-adopt.html");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(uri);
            };
            label.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}