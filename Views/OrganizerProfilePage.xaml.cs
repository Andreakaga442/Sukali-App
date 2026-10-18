using Sukali.Models;
using Sukali.Services;

namespace Sukali.Views;

public partial class OrganizerProfilePage : ContentPage
{
    public List<Event> Events { get; set; } = new();

    public OrganizerProfilePage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadData();
    }

    private void LoadData()
    {
        Events = MockDataService.Instance.Events.Take(3).ToList();
        OnPropertyChanged(nameof(Events));
    }

    private void OnFollowClicked(object sender, EventArgs e)
    {
        DisplayAlert("Abonnement", "Vous êtes maintenant abonné à Assoculture !", "OK");
    }
}
