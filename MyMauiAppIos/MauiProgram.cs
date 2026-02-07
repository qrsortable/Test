using Microsoft.Extensions.Logging;

namespace MyMauiAppIos;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
       AppDomain.CurrentDomain.UnhandledException += (s, e) =>
		{
		    Console.WriteLine(e.ExceptionObject.ToString());
		};
		
		TaskScheduler.UnobservedTaskException += (s, e) =>
		{
		    Console.WriteLine(e.Exception.ToString());
		};
		return builder.Build();
	}
}
