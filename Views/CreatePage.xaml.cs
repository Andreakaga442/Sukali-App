namespace Sukali.Views;

public partial class CreatePage : ContentPage
{
    public CreatePage()
    {
        InitializeComponent();
    }

    private void OnDraftClicked(object sender, EventArgs e)
    {
        DisplayAlert("Brouillon", "Votre événement a été enregistré comme brouillon.", "OK");
    }

    private void OnPublishClicked(object sender, EventArgs e)
    {
        DisplayAlert("Publier", "Votre événement a été publié avec succès !", "OK");
    }
}
