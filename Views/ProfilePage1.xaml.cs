namespace Sukali.Views;

public partial class ProfilePage1 : ContentPage
{
    public ProfilePage1()
    {
        InitializeComponent();
    }

    private void OnProfileTypeTapped(object sender, TappedEventArgs e)
    {
        if (sender is Frame frame)
        {
            // Réinitialiser toutes les cartes
            foreach (var child in ProfileTypeLayout.Children)
            {
                if (child is Frame f && Application.Current.Resources["CardFrame"] is Style cardStyle)
                {
                    f.Style = cardStyle;
                }
            }
            // Sélectionner celle cliquée
            if (Application.Current.Resources["CardFrameSelected"] is Style selectedStyle)
                frame.Style = selectedStyle;
        }
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ProfilePage2");
    }
}
