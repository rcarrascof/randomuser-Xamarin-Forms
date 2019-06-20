using RandomUser.Model;
using RandomUser.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RandomUser.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserDetails : ContentPage
	{
     
        public UserDetails (User selectedItem)
		{
            BindingContext =new  DetallesViewModel(this,selectedItem);
			InitializeComponent ();
           
        }

      
    }
}