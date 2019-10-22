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
            ls.ItemSelected += btnadd_Clicked;
        }

        public async Task<IEnumerable<Resturants>> GetAllPersons()
        {

            return (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Select(item => new Resturants
              {
                  tele = item.Object.tele,
                  nomclient = item.Object.nomclient,
                  name = item.Object.name,
                  cmd = item.Object.cmd
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

        private async void btnadd_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
           
            var res =(Resturants) e.SelectedItem;
           await  DisplayAlert("ok", res.nomclient.ToLower(), "ok");
            var nm = res.nomclient;
            //ls.TabIndex[e.SelectedItemIndex] = 

            
            // DeletePerson(nm);

          //  await Navigation.PushModalAsync(new Liver());
        }

        public async Task DeletePerson(string personId)
        {
            var toDeletePerson = (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Where(a => a.Object.nomclient == personId).FirstOrDefault();
            await firebase.Child("Resturant").Child(toDeletePerson.Key).DeleteAsync();

        }
    }
}