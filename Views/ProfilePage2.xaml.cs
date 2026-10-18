namespace Sukali.Views;

public partial class ProfilePage2 : ContentPage
{
    public ProfilePage2()
    {
        InitializeComponent();
    }

    private void OnCategoryTapped(object sender, TappedEventArgs e)
    {
        if (sender is Frame frame)
        {
            // Basculer entre sélectionné et non sélectionné
            var resources = Application.Current.Resources;
            if (frame.Style == resources["ChipFrameSelected"])
                frame.Style = resources["ChipFrame"] as Style;
            else
                frame.Style = resources["ChipFrameSelected"] as Style;
        }
    }

    private void OnTimeTapped(object sender, TappedEventArgs e)
    {
        if (sender is Frame frame)
        {
            frame.Style = (Style)Application.Current.Resources["ChipFrameSelected"];
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ProfilePage3");
    }
}
