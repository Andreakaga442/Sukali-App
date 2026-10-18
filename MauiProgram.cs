using Microsoft.Extensions.Logging;

namespace Sukali;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("PlusJakartaSans-Regular.ttf", "PlusJakartaSansRegular");
				fonts.AddFont("PlusJakartaSans-Bold.ttf", "PlusJakartaSansBold");
				fonts.AddFont("Caveat-Regular.ttf", "CaveatRegular");
				fonts.AddFont("Caveat-Bold.ttf", "CaveatBold");
			});

		// Enregistrement des services
		builder.Services.AddSingleton<Services.MockDataService>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
