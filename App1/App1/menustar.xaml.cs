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
    public partial class menustar : ContentPage
    {
        
        public menustar()
        {
            InitializeComponent();
            if(MainPage.n1 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");


            }
            if (MainPage.n2 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
            }
            if(MainPage.n3 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
            }
            if(MainPage.n4 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
            }
            if(MainPage.n5 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
            }
            if(MainPage.n6 == 1)
            {
                im1.Source = ImageSource.FromFile("");
                im2.Source = ImageSource.FromFile("");
                im3.Source = ImageSource.FromFile("");
                im4.Source = ImageSource.FromFile("");
                im5.Source = ImageSource.FromFile("");
                im6.Source = ImageSource.FromFile("");
                im7.Source = ImageSource.FromFile("");
                im8.Source = ImageSource.FromFile("");
            }
          


            Guest(im1, im1_click);
        }
        private  void Guest(Image im,EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            im.GestureRecognizers.Add(n);
        }
        private async void im1_click(object sender,EventArgs e)
        {
            await   Navigation.PushModalAsync(new PRoductPages());
        }
    }
}