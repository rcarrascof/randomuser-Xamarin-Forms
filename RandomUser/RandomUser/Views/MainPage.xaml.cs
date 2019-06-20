using Newtonsoft.Json;
using RandomUser.Model;
using RandomUser.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomUser.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new UsersViewModel(this);
            InitializeComponent();
           
        }

       


        private void ClientList_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

            if (args.SelectedItem == null)
            {
                return;
            }
         

            Navigation.PushAsync(new UserDetails(args.SelectedItem as User));
            clientList.SelectedItem = null;
        }
    }
}
