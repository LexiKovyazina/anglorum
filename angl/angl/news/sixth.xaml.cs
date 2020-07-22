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
    public partial class sixth : ContentPage
    {
        public sixth()
        {
            InitializeComponent();

            ToolbarItem sav = new ToolbarItem
            {
                IconImageSource = "safe.png",
            };

            ToolbarItems.Add(sav);
            Uri uri = new Uri("https://blog.britishmuseum.org/historical-city-travel-guide-london-late-16th-century/");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(uri);
            };
            label.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}