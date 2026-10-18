namespace Sukali.Models;

public class UserProfile
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public string ProfileType { get; set; } = string.Empty; // étudiant, professionnel, entrepreneur, organisateur, curieux
    public string Domain { get; set; } = string.Empty;
    public List<string> Interests { get; set; } = new();
    public string DiscoveryZone { get; set; } = string.Empty;
    public int DiscoveryRadiusKm { get; set; } = 20;
    public List<string> FollowedCountries { get; set; } = new();
    public List<int> FollowedOrganizers { get; set; } = new();
    public string PreferredTime { get; set; } = string.Empty;
}

public class Organizer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int FollowersCount { get; set; }
    public bool IsFollowed { get; set; }
    public List<string> Categories { get; set; } = new();
}
