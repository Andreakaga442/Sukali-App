namespace Sukali.Views;

public partial class SplashScreenPage2 : ContentPage
{
    public SplashScreenPage2()
    {
        InitializeComponent();
        StartAnimations();
    }

    private async void StartAnimations()
    {
        // Animation de la voiture (entre de la gauche)
        await VoitureImage.FadeTo(1, 500);
        await VoitureImage.TranslateTo(0, 0, 1500, Easing.CubicOut);

        // Animation du logo
        await Task.Delay(500);
        await LogoImage.FadeTo(1, 600);
        await LogoImage.ScaleTo(1.1, 400);
        await LogoImage.ScaleTo(1.0, 300);

        // Animation du texte
        await WelcomeLabel.FadeTo(1, 500);

        // Animation du bouton
        await Task.Delay(300);
        await StartButton.FadeTo(1, 400);
    }

    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LoginPage");
    }
}
