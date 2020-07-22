using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.Storage;
using Xamarin.Forms;
namespace angl
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        private static readonly HttpClient client = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
            

        }
         private async void firs(object sender, EventArgs e)
        {
           await Navigation.PushAsync( new angl.first ());
        }

        private async void secon(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.second());
        }

        private async void thir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.third());
        }
        private async void fort(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.forth());
        }

        private async void fift(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.fifth());
        }
        private async void sixt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.sixth());
        }

        
        private async void goal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new angl.TodoListPageCS());
        }
    }
}



