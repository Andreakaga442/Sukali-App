namespace Sukali.Models;

public class Category
{
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public bool IsSelected { get; set; }
}

public class LiveEvent
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Organizer { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int ViewersCount { get; set; }
    public string ThumbnailUrl { get; set; } = string.Empty;
    public bool IsLiveNow { get; set; }
}
