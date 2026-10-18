namespace Sukali.Views;

public partial class OrganizerAuthPage : ContentPage
{
    public OrganizerAuthPage()
    {
        InitializeComponent();
    }

    private async void OnCreateAccountClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Création de compte", "Votre demande de compte organisateur a été soumise. Vous recevrez un e-mail de confirmation après vérification.", "OK");
        await Shell.Current.GoToAsync("//LoginPage");
    }
}
