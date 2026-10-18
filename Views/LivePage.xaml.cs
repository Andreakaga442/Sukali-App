using Sukali.Models;
using Sukali.Services;

namespace Sukali.Views;

public partial class LivePage : ContentPage
{
    public List<LiveEvent> LiveEvents { get; set; } = new();

    public LivePage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadData();
    }

    private void LoadData()
    {
        LiveEvents = MockDataService.Instance.LiveEvents;
        OnPropertyChanged(nameof(LiveEvents));
    }

    private async void OnLiveTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Live", "Lecture du live en cours de développement...", "OK");
    }
}
