namespace Sukali.Models;

public class Event
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Time { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Organizer { get; set; } = string.Empty;
    public string OrganizerAvatar { get; set; } = string.Empty;
    public bool IsFree { get; set; }
    public string Price { get; set; } = string.Empty;
    public bool IsFavorite { get; set; }
    public bool IsLiked { get; set; }
    public int LikesCount { get; set; }
    public int CommentsCount { get; set; }
    public bool IsLive { get; set; }
    public string Duration { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public bool HasReservation { get; set; }
    public bool IsDraft { get; set; }
    public double DistanceKm { get; set; }
    public List<string> Tags { get; set; } = new();
}
