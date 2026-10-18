namespace Sukali.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Déconnexion", "Voulez-vous vraiment vous déconnecter ?", "Oui", "Non");
        if (confirm)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
