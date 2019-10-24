﻿using System;
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
        decimal npri;
        public Details()
        {
            InitializeComponent();
            bn.Clicked += buttonval_click;

            ls.ItemsSource = PRoductPages.cm;

            npri = (from a in PRoductPages.cm
                         select a).Sum(m => m.prix);
            tt.Text = npri.ToString();
            decimal al = npri + 5;
            to.Text = al.ToString();
        
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            bt++;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = 1;
            int s=0;
            Button b = (Button)sender;
            n++;
            b.Text = n.ToString();

            
        }
        private  async void buttonval_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new Formclie());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            
        }
    }
}