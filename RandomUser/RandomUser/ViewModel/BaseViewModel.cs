using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomUser.ViewModel
{
   public  class BaseViewModel : INotifyPropertyChanged
    {
    public event PropertyChangedEventHandler PropertyChanged;
    protected Page page { get; private set; }
    private INavigation Navigation;
    private bool isbusy;
    public bool IsBusy { get { return isbusy; } set { isbusy = value; RaiseOnPropertyChanged(); } }


    public BaseViewModel(Page page)
    {
        this.page = page;
        Navigation = page.Navigation;
     
    }

    public void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected Task PushAsync(Page page)
    {
        return Navigation.PushAsync(page);
    }

    protected Task PushModalAsync(Page page)
    {
        return Navigation.PushModalAsync(page);
    }

    protected Task PopAsync(bool animate)
    {
        return Navigation.PopAsync(animate);
    }

    protected Task PopModalAsync(bool animate)
    {
        return Navigation.PopModalAsync(animate);
    }

    protected Task DisplayAlert(string title, string message, string cancel = "Aceptar")
    {
        return page.DisplayAlert(title, message, cancel);
    }

    protected Task<bool> DisplayAlert(string title, string message, string accept, string cancel = "Aceptar")
    {
        return page.DisplayAlert(title, message, accept, cancel);
    }

    protected Task<string> DisplayActionSheet(string Title, params string[] buttons)
    {
        return page.DisplayActionSheet(Title, "Aceptar", null, buttons);
    }

    public virtual bool OnBackButtonPressed()
    {
        return true;
    }
}
}
