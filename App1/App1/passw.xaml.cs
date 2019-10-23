using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class passw : ContentPage
    {
      public static int n1 = 0,n2 = 0;
        public static string email;
        public static string pass;

        public passw()
        {
            InitializeComponent();
            btn.Clicked += btn_click;
        }
        private async void btn_click(object sender,EventArgs e)
        {
            try
            {
                email = "";
                pass = "";

                if (txtemail.Text.Contains("Hamzalivreurr@gmail.com") && txtpas.Text.Contains("Gerfast1230"))
                {
                    n1 = 1;
                    n2 = 0;
                    email = txtemail.Text;
                    pass = txtpas.Text;
                    await Navigation.PushModalAsync(new Liver());
                }
                if (txtemail.Text.Equals("mohamedlivreurr@gmail.com") && txtpas.Text.Equals("Gerfast1230"))
                {
                    n2 = 1;
                    n1 = 0;
                    email = txtemail.Text;
                    pass = txtpas.Text;
                    await Navigation.PushModalAsync(new Liver());
                }
            }catch(Exception)
            {
              await  DisplayAlert("تنبيه", "المعلومات غير صحيحة", "حسنا");
            }
        }
    }
}