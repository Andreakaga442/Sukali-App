namespace Sukali.Views;

public partial class SplashScreenPage1 : ContentPage
{
    public SplashScreenPage1()
    {
        InitializeComponent();
        StartAnimations();
    }

    private async void StartAnimations()
    {
        // Animation du logo
        await LogoImage.FadeTo(1, 800);
        await LogoImage.ScaleTo(1.2, 600);
        await LogoImage.ScaleTo(1.0, 400);

        // Animation du slogan
        await SloganLabel.FadeTo(1, 600);

        // Animation du chargement
        await LoadingIndicator.FadeTo(1, 400);

        // Attente puis navigation
        await Task.Delay(1500);
        await Shell.Current.GoToAsync("//SplashScreenPage2");
    }

    private void OnLogoTapped(object sender, TappedEventArgs e)
    {
        // Animation au tap
        LogoImage.ScaleTo(1.1, 200).ContinueWith(async _ =>
        {
            await LogoImage.ScaleTo(1.0, 200);
        });
    }
}
