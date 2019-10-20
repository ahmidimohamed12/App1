using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            guest(im1, im1_click);
        }

        private void guest(Image im,EventHandler l)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += l;
            im.GestureRecognizers.Add(n);
        }
        private  void im1_click(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new menustar());
        }
    }
}
