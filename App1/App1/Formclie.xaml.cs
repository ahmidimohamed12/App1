using System;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Models;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formclie : ContentPage
    {
        public FirebaseClient firebase = new FirebaseClient("https://gerfast-86de6.firebaseio.com/");

        public Formclie()
        {
            InitializeComponent();
            bt.Clicked += valid;
        }
        private async void  valid(object sender,EventArgs e)
        {
            if (nom.Text != " " || numtele.Text != " ")
            {
                //int t;
                //t = (from a in
                //        select a).;

                //await firebase
                  //.Child("Resturant")
                  //.PostAsync(new Resturants() { id = 0, name = MainPage.namerst, cmd =, total = 0 }) ;
            }

        }
        public async Task SendSms(string messageText, string recipient)
        {
            try
            {
                var message = new SmsMessage(messageText, recipient);
                await Sms.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Failed", "Sms is not supported on this device.","OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Failed", ex.Message, "OK");
            }
        }
    }
}