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
    public partial class ville : ContentPage
    {
        string action;
        public ville()
        {
            InitializeComponent();
            bb.Clicked += btn2_click;
            tt.Clicked += btn1_click;
        }

        private async void btn1_click(object sender,EventArgs e)
        {
            try
            {
                if (action.Length >= 4)
                    await Navigation.PushModalAsync(new MainPage());
            }catch(Exception)
            {

            }
         }
        private  async void btn2_click(object sender,EventArgs e)
        {
            try
            {
                action = await DisplayActionSheet("المرجو إختيار المدينة", null, null, "أولآاد تايمة");
                bb.Text = action.ToString();
            }catch(Exception)
            {

            }
        }
    }
}