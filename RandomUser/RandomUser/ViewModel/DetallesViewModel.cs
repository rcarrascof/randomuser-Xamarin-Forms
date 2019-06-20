using RandomUser.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RandomUser.ViewModel
{
   
    public class DetallesViewModel : BaseViewModel
    {
         public Name user { get; set; }
         public Name Usuario { get => user; set { user = value; RaiseOnPropertyChanged(); } }
         public string cellphone { get; set; }
        public string email { get; set; }
        public DetallesViewModel(Page page,User user) : base(page)
        {

            Usuario = user.Name;
            cellphone = user.Cell;
            email = user.Email;
        }

           
    }

       
    
}
