using Sukali.Models;
using Sukali.Services;

namespace Sukali.Views;

public partial class ExplorePage : ContentPage
{
    public List<Category> Categories { get; set; } = new();
    public List<Event> Events { get; set; } = new();

    public ExplorePage()
    {
        InitializeComponent();
        BindingContext = this;
        LoadData();
    }

    private void LoadData()
    {
        Categories = MockDataService.Instance.Categories;
        Events = MockDataService.Instance.Events;
        OnPropertyChanged(nameof(Categories));
        OnPropertyChanged(nameof(Events));
    }

    private void OnCategoryTapped(object sender, TappedEventArgs e)
    {
        // Filtrer par catégorie
    }

    private async void OnEventTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//EventDetailPage");
    }
}
