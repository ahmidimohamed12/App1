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
        public static int tpizza, tburger, tchawar,tsalad, tpanini, tpate,ttacos,tchicken,tglace,tdessert,tjus;
        public FirebaseClient firebase = new FirebaseClient("https://gerfast-86de6.firebaseio.com/");
        public static string command;
        public menustar()
        {
            InitializeComponent();
        


            Guest(im1, im1_click);
            Guest(im2, im2_click);
            Guest(im3, im3_click);
            Guest(im4, im4_click);
            Guest(im5, im5_click);
            Guest(im6, im6_click);
            Guest(im7, im7_click);
            Guest(im8, im8_click);
            Guest(im9, im9_click);
            Guest(im10, im10_click);

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

            tchawar = 0;
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

            tchawar = 0;
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

            tchawar = 0;
            await  Navigation.PushModalAsync(new PRoductPages());
        }
        private async void  im4_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 1;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;

            tchawar = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private  async void im5_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 1;
            tjus = 0;

            tchawar = 0;
            tchicken = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im6_click(object sender, EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 1;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;

            tchawar = 0;
            tdessert = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private  async void im7_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 1;
            tdessert = 0;

            tchawar = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im8_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;
            tchawar = 1;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im9_click(object sender,EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 1;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 0;

            tchawar = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
        private async void im10_click(object sender, EventArgs e)
        {
            tpizza = 0;
            tburger = 0;
            tglace = 0;
            tsalad = 0;
            ttacos = 0;
            tpanini = 0;
            tpate = 0;
            tjus = 0;
            tchicken = 0;
            tdessert = 1;

            tchawar = 0;
            await Navigation.PushModalAsync(new PRoductPages());
        }
    }
}