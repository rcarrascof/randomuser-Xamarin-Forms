using Newtonsoft.Json;
using RandomUser.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace RandomUser.ViewModel
{
    public class UsersViewModel : BaseViewModel
    {
        public List<User> listSource;
        public List<User> ListSource { get => listSource; set { listSource = value; RaiseOnPropertyChanged(); } }
        public UsersViewModel(Page page) : base(page)
        {

            getNames();
        }


        private async void getNames()
        {
            IsBusy = true;
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("https://randomuser.me/api/?results=100");

               var obj = JsonConvert.DeserializeObject<RootObject>(response);

                ListSource = obj.Users;
            }catch(Exception e)
            {
               await DisplayAlert("Error", e.Message, "Aceptar");
            }
            IsBusy = false;

        }
    }
}
