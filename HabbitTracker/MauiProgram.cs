using Microsoft.Extensions.Logging;

namespace HabbitTracker
{
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
                    fonts.AddFont("Poppins-Black.ttf", "Poppins-Black");
                    fonts.AddFont("Poppins-BlackItalic.ttf", "Poppins-BlackItalic");
                    fonts.AddFont("Poppins-Regular.ttf", "Poppins-Regular"); 
                    fonts.AddFont("Poppins-ExtraBold.ttf", "Poppins-ExtraBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
