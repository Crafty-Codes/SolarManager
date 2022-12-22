using SolarManager.ViewModels;
using System.Net;
using System.Text.RegularExpressions;

namespace SolarManager;

public partial class MainPage : ContentPage
{
    private string ipAddress = "";

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        ipAddress = ((Entry)sender).Text;
    }

    private void OnEntryCompleted(object sender, EventArgs e)
    {
        ipAddress = ((Entry)sender).Text;
    }

    private void OnSend(object sender, EventArgs e)
    {
        
    }
}

