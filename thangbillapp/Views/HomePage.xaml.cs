using thangbillapp.ViewModels;

namespace thangbillapp.Views;

public partial class HomePage : ContentPage
{

    public HomePage(HomeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        //await ((HomeViewModel)BindingContext).CreateDataExclusiveProducts();
    }
}