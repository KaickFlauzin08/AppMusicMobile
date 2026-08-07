using Microsoft.Extensions.Logging;

namespace AppMusic
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
                    fonts.AddFont("DidactGothic-Regular.ttf", "DidactGothic");
                    fonts.AddFont("Mulish-Regular.ttf", "Mulish");
                    fonts.AddFont("centurygothic_bold.ttf", "century");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
