namespace Sukali.Views;

public partial class EventDetailPage : ContentPage
{
    public EventDetailPage()
    {
        InitializeComponent();
    }

    private void OnLikeClicked(object sender, EventArgs e)
    {
        DisplayAlert("J'aime", "Vous avez aimé cet événement !", "OK");
    }

    private async void OnCommentClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CommentsPage");
    }

    private void OnShareClicked(object sender, EventArgs e)
    {
        DisplayAlert("Partager", "Lien de partage copié !", "OK");
    }
}
