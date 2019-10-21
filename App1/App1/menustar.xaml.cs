using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Models;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menustar : ContentPage
    {
        public static int tpizza, tburger, tsalad, tpanini, tpate,ttacos,tchicken,tglace,tdessert,tjus;
        public FirebaseClient firebase = new FirebaseClient("https://gerfast-86de6.firebaseio.com/");

        public menustar()
        {
            InitializeComponent();
            //if(MainPage.n1 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("brg1.png");
            //    im2.Source = ImageSource.FromFile("tcs1.png");
            //    im3.Source = ImageSource.FromFile("wr1.png");
            //    im4.Source = ImageSource.FromFile("pann1.png");
            //    im5.Source = ImageSource.FromFile("pz1.png");
            //    im6.Source = ImageSource.FromFile("sld1.png");
            //    im7.Source = ImageSource.FromFile("ch1.png");
            //    im8.Source = ImageSource.FromFile("gl1.png");
            //    im9.Source = ImageSource.FromFile("");
            //    im10.Source = ImageSource.FromFile("");


            //}
            //if (MainPage.n2 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("");
            //    im2.Source = ImageSource.FromFile("");
            //    im3.Source = ImageSource.FromFile("");
            //    im4.Source = ImageSource.FromFile("");
            //    im5.Source = ImageSource.FromFile("");
            //    im6.Source = ImageSource.FromFile("");
            //    im7.Source = ImageSource.FromFile("");
            //    im8.Source = ImageSource.FromFile("");
            //}
            //if(MainPage.n3 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("");
            //    im2.Source = ImageSource.FromFile("");
            //    im3.Source = ImageSource.FromFile("");
            //    im4.Source = ImageSource.FromFile("");
            //    im5.Source = ImageSource.FromFile("");
            //    im6.Source = ImageSource.FromFile("");
            //    im7.Source = ImageSource.FromFile("");
            //    im8.Source = ImageSource.FromFile("");
            //}
            //if(MainPage.n4 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("");
            //    im2.Source = ImageSource.FromFile("");
            //    im3.Source = ImageSource.FromFile("");
            //    im4.Source = ImageSource.FromFile("");
            //    im5.Source = ImageSource.FromFile("");
            //    im6.Source = ImageSource.FromFile("");
            //    im7.Source = ImageSource.FromFile("");
            //    im8.Source = ImageSource.FromFile("");
            //}
            //if(MainPage.n5 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("pz1.png");
            //    im2.Source = ImageSource.FromFile("tcs1.png");
            //    im3.Source = ImageSource.FromFile("ch1.png");
            //    im4.Source = ImageSource.FromFile("");
            //    im5.Source = ImageSource.FromFile("");
            //    im6.Source = ImageSource.FromFile("");
            //    im7.Source = ImageSource.FromFile("");
            //    im8.Source = ImageSource.FromFile("");
            //}
            //if(MainPage.n6 == 1)
            //{
            //    im1.Source = ImageSource.FromFile("");
            //    im2.Source = ImageSource.FromFile("");
            //    im3.Source = ImageSource.FromFile("");
            //    im4.Source = ImageSource.FromFile("");
            //    im5.Source = ImageSource.FromFile("");
            //    im6.Source = ImageSource.FromFile("");
            //    im7.Source = ImageSource.FromFile("");
            //    im8.Source = ImageSource.FromFile("");
            //}


            Guest(im1, im1_click);
            Guest(im2, im2_click);
            Guest(im3, im3_click);
            Guest(im4, im4_click);
            Guest(im5, im5_click);
            Guest(im6, im6_click);
        }
        private  void Guest(Image im,EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            im.GestureRecognizers.Add(n);
        }
        private async void im1_click(object sender,EventArgs e)
        {
            tpizza = 1;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
           await  Navigation.PushModalAsync(new PRoductPages());
        }
    private async void im2_click(object sender,EventArgs e)
        {
          
            tpizza = 0;
            tburger = 1;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im3_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await  Navigation.PushModalAsync(new PRoductPages());
        }
        private async void  im4_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private  async void im5_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im6_click(object sender, EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private  async void im7_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im8_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im9_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 1;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
    }
}