using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Navigation.PushModalAsync(new MainPage());
                return false;
            });

        }
    }
}