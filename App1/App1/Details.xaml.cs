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
    public partial class Details : ContentPage
    {
        int bt = 0;
        
        public Details()
        {
            InitializeComponent();
            bn.Clicked += buttonval_click;
            ls.ItemsSource = PRoductPages.cm;
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            bt++;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = 1;
            Button b = (Button)sender;
            b.Text +=int.Parse(n.ToString());
        }
        private  async void buttonval_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new Formclie());
        }
    }
}