using Sukali.Models;
using Sukali.Services;

namespace Sukali.Views;

public partial class ProfileSpacePage : ContentPage
{
    public List<Event> MyEvents { get; set; } = new();

    public ProfileSpacePage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadData();
    }

    private void LoadData()
    {
        MyEvents = MockDataService.Instance.Events.Take(3).ToList();
        OnPropertyChanged(nameof(MyEvents));
    }

    private async void OnEventTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//EventDetailPage");
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Déconnexion", "Voulez-vous vraiment vous déconnecter ?", "Oui", "Non");
        if (confirm)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }

    private async void OnNotificationsTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//NotificationsPage");
    }

    private async void OnSettingsTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//SettingsPage");
    }
}
