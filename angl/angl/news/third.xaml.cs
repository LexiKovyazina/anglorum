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
    public partial class third : ContentPage
    {
        public third()
        {
            InitializeComponent();

            ToolbarItem sav = new ToolbarItem
            {
                IconImageSource = "sav.png",
                Priority=2,
            };


            ToolbarItems.Add(sav);



            Uri uri = new Uri("https://www.coursera.org/learn/lesson-small-talk-and-conversational-vocabulary");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(uri);
            };
            th.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}