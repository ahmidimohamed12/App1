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
        decimal npri;
        public static List<decimal> pr = new List<decimal>();
        public static   decimal al;
        public Details()
        {
            InitializeComponent();
            bn.Clicked += buttonval_click;

            ls.ItemsSource = PRoductPages.cm;

            npri = (from a in PRoductPages.cm
                         select a).Sum(m => m.prix);
            tt.Text = npri.ToString();
         al  = npri + 5;
            to.Text = al.ToString();



        
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            bt++;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            decimal n = 1;
            decimal s=0;
            Button b = (Button)sender;
            n++;
            b.Text = n.ToString();
            pr.Add(n);

            

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