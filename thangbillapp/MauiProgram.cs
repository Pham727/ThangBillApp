using Newtonsoft.Json;
using Refit;
using thangbillapp.ApiServices;
using thangbillapp.Services;
using thangbillapp.Utils;
using thangbillapp.ViewModels;
using thangbillapp.Views;

namespace thangbillapp;

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
            })
            .RegisterServices()
            .RegisterRefitClients();

        //add page
        builder.Services.AddSingleton<SignInPage>();
        builder.Services.AddSingleton<SignUpPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<ProductDetailPage>();
        builder.Services.AddSingleton<CartPage>();
        builder.Services.AddSingleton<TabPage>();

        //add viewmodel
        builder.Services.AddSingleton<SignInViewModel>();
        builder.Services.AddSingleton<SignUpViewModel>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<ProductDetailViewModel>();
        builder.Services.AddSingleton<CartViewModel>();

        return builder.Build();
    }


    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<IProductServices, ProductServices>();
        mauiAppBuilder.Services.AddSingleton<ApiConfig>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterRefitClients(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddRefitClient<IApiService>()
                        .ConfigureHttpClient(c =>
                        {
                            c.BaseAddress = new Uri(Constants.BASE_URL);
                        })
                        .AddHttpMessageHandler<ApiConfig>();

        return mauiAppBuilder;
    }
}
