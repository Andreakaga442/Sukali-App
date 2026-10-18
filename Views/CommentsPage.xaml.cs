namespace Sukali.Views;

public partial class CommentsPage : ContentPage
{
    public CommentsPage()
    {
        InitializeComponent();
    }

    private void OnSendClicked(object sender, EventArgs e)
    {
        DisplayAlert("Commentaire", "Votre commentaire a été envoyé !", "OK");
    }
}
