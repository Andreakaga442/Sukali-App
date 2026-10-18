namespace Sukali.Views;

public partial class ProfilePage3 : ContentPage
{
    public ProfilePage3()
    {
        InitializeComponent();
    }

    private void OnCountryTapped(object sender, TappedEventArgs e)
    {
        if (sender is Frame frame)
        {
            var resources = Application.Current.Resources;
            if (frame.Style == resources["ChipFrameSelected"])
                frame.Style = resources["ChipFrame"] as Style;
            else
                frame.Style = resources["ChipFrameSelected"] as Style;
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnStartClicked(object sender, EventArgs e)
    {
        // Navigation vers l'application principale
        await Shell.Current.GoToAsync("//MainTabs");
    }
}
