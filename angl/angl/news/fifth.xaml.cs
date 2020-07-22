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
    public partial class fifth : ContentPage
    {
        public fifth()
        {

            InitializeComponent();
            ToolbarItem sav = new ToolbarItem
            {
                IconImageSource = "sav.png",
            };

            ToolbarItems.Add(sav);

            Uri uri = new Uri("https://www.youtube.com/watch?v=-uR-iqh1x1Q");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(uri);
            };
            label.GestureRecognizers.Add(tapGestureRecognizer);
        
        }
    }
}