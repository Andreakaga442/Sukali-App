using Sukali.Models;
using Sukali.Services;

namespace Sukali.Views;

public partial class HomePage : ContentPage
{
    public List<Event> Events { get; set; } = new();
    public List<Story> Stories { get; set; } = new();

    public HomePage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadData();
    }

    private void LoadData()
    {
        Events = MockDataService.Instance.Events;
        Stories = new List<Story>
        {
            new() { Name = "Assoculture", Avatar = "🎵" },
            new() { Name = "TechCameroun", Avatar = "💻" },
            new() { Name = "ArtCameroun", Avatar = "🎨" },
            new() { Name = "FECAFOOT", Avatar = "⚽" },
        };
        OnPropertyChanged(nameof(Events));
        OnPropertyChanged(nameof(Stories));
    }

    private async void OnEventTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//EventDetailPage");
    }
}

public class Story
{
    public string Name { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
}
