using System;
using System.Collections.Generic;
using System.Text;
using App1.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using Xamarin.Forms;

namespace App1.Models
{
  public  class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://xamarinfirebase-909d2.firebaseio.com/");

        public async Task<List<Resturants>> GetAllPersons()
        {

            return (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Select(item => new Resturants
              {
                  id = item.Object.id,
                  name = item.Object.name
              }).ToList();
        }

        public async Task AddPerson(int personId, string name)
        {

            await firebase
              .Child("Resturant")
              .PostAsync(new Resturants() { id = personId, name = name });
        }

        public async Task<Resturants> GetPerson(int personId)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>();
            return allPersons.Where(a => a.id == personId).FirstOrDefault();
        }

        public async Task UpdatePerson(int personId, string name)
        {
            var toUpdatePerson = (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Where(a => a.Object.id == personId).FirstOrDefault();

            await firebase
              .Child("Resturant")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Resturants() { id = personId, name = name });
        }

        public async Task DeletePerson(int personId)
        {
            var toDeletePerson = (await firebase
              .Child("Resturant")
              .OnceAsync<Resturants>()).Where(a => a.Object.id == personId).FirstOrDefault();
            await firebase.Child("Resturant").Child(toDeletePerson.Key).DeleteAsync();

        }
    }
}
