﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Models;
namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static List<Resturants> res;
        public static Resturants rs = new Resturants();

      public static  int n1, n2, n3, n4, n5, n6;
        public static string namerst;
        public MainPage()
        {
            InitializeComponent();
            guest(im1, im1_click);
            guest(im2, im2_click);
            guest(im3, im3_click);
            guest(im4, im4_click);
            guest(im5, im5_click);
            guest(im6, im6_click);
        }

        private void guest(Image im,EventHandler l)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += l;
            im.GestureRecognizers.Add(n);
        }
        private async  void im1_click(object sender,EventArgs e)
        {
            rs = new Resturants();
            n1 = 1;
            n2 = 0;
            n3 = 0;
            n4 = 0;
            n5 = 0;
            namerst = "skyfood";
            n6 = 0;
            rs.name = namerst;
                await    Navigation.PushModalAsync(new menustar());
        }
        private async void  im2_click(object sender,EventArgs e)
        {
            rs = new Resturants();
            n1 = 0;
            n2 = 1;
            n3 = 0;
            n4 = 0;
            n5 = 0;
            n6 = 0;

            namerst = "Torino Food";

            rs.name = namerst;
            await Navigation.PushModalAsync(new menustar());
        }
        private async void im3_click(object sender,EventArgs e)
        {
            rs = new Resturants();
            n1 = 0;
            n2 = 0;
            n3 = 1;
            n4 = 0;
            n5 = 0;
            n6 = 0;
            namerst = "Pizza Idriss";
            rs.name = namerst;
            await Navigation.PushModalAsync(new menustar());
        }
        private async void im4_click(object sender,EventArgs e)
        {
            rs = new Resturants();
            n1 = 0;
            n2 = 0;
            n3 = 0;
            n4 = 1;
            n5 = 0;
            n6 = 0;
            namerst = "skyfood";
            rs.name = namerst;
            await Navigation.PushModalAsync(new menustar());
        }
        private async void im5_click(object sender,EventArgs E)
        {
            rs = new Resturants();
            n1 = 0;
            n2 = 0;
            n3 = 0;
            n4 = 0;
            n5 = 1;
            n6 = 0;
            namerst = "Tomaya";
            rs.name = namerst;
            await Navigation.PushModalAsync(new menustar());
        }
        private  async void im6_click(object sender,EventArgs e)
        {
            rs = new Resturants();
            n1 = 0;
            n2 = 0;
            n3 = 0;
            n4 = 0;
            n5 = 0;
            n6 = 1;
            namerst = "skyfood";
            rs.name = namerst;
            await Navigation.PushModalAsync(new menustar());
        }
    }
}
