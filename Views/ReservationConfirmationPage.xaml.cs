namespace Sukali.Views;

public partial class ReservationConfirmationPage : ContentPage
{
    public ReservationConfirmationPage()
    {
        InitializeComponent();
    }

    private async void OnViewReservationsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ProfileSpacePage");
    }

    private async void OnBackToHomeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainTabs");
    }
}
