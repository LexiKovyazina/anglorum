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
    public partial class first : ContentPage
    {
        public first()
        {
            InitializeComponent();

            ToolbarItem sav = new ToolbarItem
            {
                IconImageSource = "sav.png",
            };

            ToolbarItems.Add(sav);




            Uri uri = new Uri("https://jamesclear.com/article");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(uri);
            };
            label.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}