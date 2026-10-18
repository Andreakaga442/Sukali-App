using Sukali.Models;

namespace Sukali.Services;

public class MockDataService
{
    private static MockDataService? _instance;
    public static MockDataService Instance => _instance ??= new MockDataService();

    public UserProfile CurrentUser { get; set; } = new()
    {
        Name = "Andrea Kaga",
        Email = "andrea.kaga@example.com",
        ProfileType = "Étudiante",
        Domain = "Informatique",
        DiscoveryZone = "Douala",
        DiscoveryRadiusKm = 20,
        Interests = new() { "Musique", "Conférences", "Ateliers" },
        PreferredTime = "Soir"
    };

    public List<Category> Categories { get; private set; } = new()
    {
        new() { Name = "Concours", Icon = "🏆", Color = "#FFE6A7" },
        new() { Name = "Musique", Icon = "🎵", Color = "#E8D5B7" },
        new() { Name = "Ateliers", Icon = "🎨", Color = "#D4C4B0" },
        new() { Name = "Conférences", Icon = "🎤", Color = "#F0E0CC" },
        new() { Name = "Sport", Icon = "⚽", Color = "#E8D5B7" },
        new() { Name = "Culture", Icon = "🎭", Color = "#D4C4B0" },
        new() { Name = "Éducation", Icon = "📚", Color = "#F0E0CC" },
        new() { Name = "Professionnel", Icon = "💼", Color = "#E8D5B7" },
    };

    public List<Event> Events { get; private set; } = new()
    {
        new()
        {
            Id = 1,
            Title = "Festival de Musique de Douala",
            Description = "Un festival réunissant les meilleurs artistes locaux et internationaux pour une soirée inoubliable.",
            Location = "Palais des Sports de Douala",
            City = "Douala",
            Date = DateTime.Now.AddDays(3),
            Time = "18:00",
            Category = "Musique",
            ImageUrl = "concert1.jpg",
            Organizer = "Assoculture",
            IsFree = false,
            Price = "5000 FCFA",
            LikesCount = 234,
            CommentsCount = 45,
            Duration = "4 heures",
            Capacity = 500,
            HasReservation = true,
            Tags = new() { "musique", "festival", "live" }
        },
        new()
        {
            Id = 2,
            Title = "Conférence : Entrepreneuriat Digital",
            Description = "Découvrez les clés pour lancer votre entreprise digitale au Cameroun.",
            Location = "ENSP Douala",
            City = "Douala",
            Date = DateTime.Now.AddDays(5),
            Time = "14:00",
            Category = "Conférences",
            ImageUrl = "concert2.jpg",
            Organizer = "TechCameroun",
            IsFree = true,
            LikesCount = 89,
            CommentsCount = 12,
            Duration = "2 heures",
            Capacity = 120,
            HasReservation = true,
            Tags = new() { "business", "digital", "tech" }
        },
        new()
        {
            Id = 3,
            Title = "Atelier de Peinture Moderne",
            Description = "Initiez-vous aux techniques de peinture moderne avec des artistes locaux.",
            Location = "Galerie des Arts",
            City = "Douala",
            Date = DateTime.Now.AddDays(7),
            Time = "10:00",
            Category = "Ateliers",
            ImageUrl = "bigbang.jpg",
            Organizer = "ArtCameroun",
            IsFree = false,
            Price = "3000 FCFA",
            LikesCount = 56,
            CommentsCount = 8,
            Duration = "3 heures",
            Capacity = 30,
            HasReservation = true,
            Tags = new() { "art", "peinture", "créativité" }
        },
        new()
        {
            Id = 4,
            Title = "Match de Football Local",
            Description = "Finale du championnat local de football.",
            Location = "Stade de la Réunification",
            City = "Douala",
            Date = DateTime.Now.AddDays(1),
            Time = "16:00",
            Category = "Sport",
            ImageUrl = "concert1.jpg",
            Organizer = "FECAFOOT",
            IsFree = true,
            LikesCount = 178,
            CommentsCount = 34,
            Duration = "2 heures",
            Capacity = 2000,
            HasReservation = false,
            Tags = new() { "football", "sport", "finale" }
        },
        new()
        {
            Id = 5,
            Title = "Soirée Culturelle Camerounaise",
            Description = "Découvrez la richesse culturelle du Cameroun à travers danse, musique et gastronomie.",
            Location = "Centre Culturel Camerounais",
            City = "Yaoundé",
            Date = DateTime.Now.AddDays(10),
            Time = "19:00",
            Category = "Culture",
            ImageUrl = "concert2.jpg",
            Organizer = "Ministère de la Culture",
            IsFree = true,
            LikesCount = 312,
            CommentsCount = 67,
            Duration = "5 heures",
            Capacity = 300,
            HasReservation = true,
            Tags = new() { "culture", "danse", "gastronomie" }
        },
        new()
        {
            Id = 6,
            Title = "Hackathon Innovation Tech",
            Description = "48h pour créer une solution technologique innovante.",
            Location = "Incubator ENSP",
            City = "Douala",
            Date = DateTime.Now.AddDays(14),
            Time = "08:00",
            Category = "Professionnel",
            ImageUrl = "bigbang.jpg",
            Organizer = "Douala Tech Hub",
            IsFree = false,
            Price = "10000 FCFA",
            LikesCount = 145,
            CommentsCount = 23,
            Duration = "48 heures",
            Capacity = 100,
            HasReservation = true,
            Tags = new() { "tech", "hackathon", "innovation" }
        }
    };

    public List<LiveEvent> LiveEvents { get; private set; } = new()
    {
        new() { Id = 1, Title = "Concert Live - Folk", Organizer = "MusicLive", Location = "Douala", ViewersCount = 234, IsLiveNow = true, ThumbnailUrl = "concert1.jpg" },
        new() { Id = 2, Title = "Débat : Politique Africaine", Organizer = "AfriDebate", Location = "Yaoundé", ViewersCount = 89, IsLiveNow = true, ThumbnailUrl = "Concert2.jpg" },
        new() { Id = 3, Title = "Cours de Cuisine en Direct", Organizer = "ChefCameroun", Location = "Douala", ViewersCount = 156, IsLiveNow = true, ThumbnailUrl = "bigbang.jpg" },
    };

    public List<Event> GetEventsByCategory(string category)
    {
        if (string.IsNullOrEmpty(category) || category == "Tous")
            return Events;
        return Events.Where(e => e.Category == category).ToList();
    }

    public List<Event> GetLiveEvents()
    {
        return Events.Where(e => e.IsLive).ToList();
    }

    public List<Event> GetFavoriteEvents()
    {
        return Events.Where(e => e.IsFavorite).ToList();
    }

    public Event? GetEventById(int id)
    {
        return Events.FirstOrDefault(e => e.Id == id);
    }
}
