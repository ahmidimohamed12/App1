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
    public partial class HomeLiver : ContentPage
    {
        public HomeLiver()
        {
            InitializeComponent();
            btn.Clicked += btn_click;
        }
    private async void btn_click(object sender,EventArgs e)
        {
           await Navigation.PushModalAsync(new passw());
        }
    }
}