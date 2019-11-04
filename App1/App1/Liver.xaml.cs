using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Mail;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Liver : ContentPage
    {
       public List<Resturants> l;
    public    FirebaseHelper firebaseHelper = new FirebaseHelper();
        List<Resturants> group = new List<Resturants>();
        public FirebaseClient firebase = new FirebaseClient("https://gerfast-86de6.firebaseio.com/");
        public Liver()
        {
            InitializeComponent();
            ls.ItemSelected += btnadd_Clicked;
            btvl.Clicked += sele;
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
                  cmd = item.Object.cmd,
                  Datetime = item.Object.Datetime,
                  addr = item.Object.addr
              }).ToList();
        }
        private async void sele(object sender, EventArgs e)
        {
            try
            {
                var p = await GetAllPersons();
                string t = "";
                List<Resturants> r = p.ToList();
                for(int i  = 0;i<r.Count;i++)
                {
                    t +="********"+ i + "Command  :" + r[i].cmd + "\\ Client Nom :" + r[i].nomclient + "\\" + " Adress :" + r[i].addr + "\\ Resturant :" + r[i].name + r[i] + "\\ Telephone :" + r[i].tele+"*************";
                }
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com", 587);
                mail.From = new MailAddress("ahmidinador123@gmail.com");
                mail.To.Add(passw.email);
                mail.Subject = "Command";
                mail.Body = t.ToString();
                //   smtpServer.Credentials = new NetworkCredential(passw.email, passw.pass);
                smtpServer.Credentials = new NetworkCredential("helpplankit@gmail.com", "mohamoha1230");
                smtpServer.UseDefaultCredentials = false;
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                var mmail = new MailMessage();
                var ssmtpServer = new SmtpClient("smtp.gmail.com", 587);
                mmail.From = new MailAddress("helpplankit@gmail.com");
                mmail.To.Add("helpplankit@gmail.com");
                mmail.Subject = "Command"+passw.email.ToString();
                mmail.Body = t.ToString();
                //   smtpServer.Credentials = new NetworkCredential(passw.email, passw.pass);
                ssmtpServer.Credentials = new NetworkCredential("helpplankit@gmail.com", "mohamoha1230");
                ssmtpServer.UseDefaultCredentials = false;
                ssmtpServer.EnableSsl = true;
                ssmtpServer.Send(mmail);


                await DeleteallPerson();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Faild", ex.Message, "OK");
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allPersons = await GetAllPersons();
            ls.ItemsSource = allPersons.ToList();
            l = allPersons.ToList();
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
        public async Task DeleteallPerson()
        {
            var toDeletePerson = (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).ToList();
            await firebase.Child("Resturant").DeleteAsync();

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