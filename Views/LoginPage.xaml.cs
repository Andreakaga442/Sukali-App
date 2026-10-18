namespace Sukali.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigation vers la page de profil (étape 1)
        await Shell.Current.GoToAsync("//ProfilePage1");
    }
}
