using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Mail;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Liver : ContentPage
    {
    public    FirebaseHelper firebaseHelper = new FirebaseHelper();
        List<Resturants> group = new List<Resturants>();
        public FirebaseClient firebase = new FirebaseClient("https://gerfast-86de6.firebaseio.com/");
        public Liver()
        {
            InitializeComponent();
        }

        public async Task<IEnumerable<Resturants>> GetAllPersons()
        {

            return (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Select(item => new Resturants
              {
                  id = item.Object.id,
                  name = item.Object.name
              }).ToList();
        }
        private void sele(object sender, SelectedItemChangedEventArgs e)
        {
          
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allPersons = await GetAllPersons();
            
            ls.ItemsSource = allPersons.ToList();
        }
          public async Task<Resturants> GetPerson(int personId)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>();
            return allPersons.Where(a => a.id == personId).FirstOrDefault();
        }
        private async void BtnRetrive_Clicked(object sender, EventArgs e)
        {
            var rest = await firebaseHelper.GetPerson(Convert.ToInt32(1));
            if (rest != null)
            {
                //b.Text = rest.id.ToString();
                //b.Text += rest.name;
                await DisplayAlert("Success", "Person Retrive Successfully", "OK");

            }
            else
            {
                await DisplayAlert("Success", "No Person Available", "OK");
            }

        }

        private async void btnadd_Clicked(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //StackLayout listViewItem = (StackLayout)button.Parent;
            //Label label = (Label)listViewItem.Children[0];

            //String text = label.Text;

            ListView l = (ListView)sender;

            var res = (Resturants)l.SelectedItem;
            await DisplayAlert("ok", res.name.ToLower(), "ok");
        }


    }
}