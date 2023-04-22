using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Firebase.Auth.Providers;
using thangbillapp.Utils;
using thangbillapp.Views;

namespace thangbillapp.ViewModels
{
    public partial class SignUpViewModel : ObservableObject
    {
        [ObservableProperty]
        string imagePass;

        [ObservableProperty]
        bool isShowPassWord;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        public SignUpViewModel()
        {
            IsShowPassWord = true;
            ImagePass = "icon_hide.png";
        }

        [RelayCommand]
        public void ShowPassword()
        {
            IsShowPassWord = !IsShowPassWord;
            if (IsShowPassWord)
            {
                ImagePass = "icon_hide.png";
            }
            else
            {
                ImagePass = "icon_eye.png";
            }
        }

        [RelayCommand]
        public async Task SignIn()
        {
            await Shell.Current.GoToAsync(nameof(SignInPage));
        }

        [RelayCommand]
        private async void RegisterUser()
        {
            try
            {
                var config = new FirebaseAuthConfig()
                {
                    ApiKey = Constants.WEB_API_KEY,
                    AuthDomain = "thangbillapp.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                    {
                        new EmailProvider(),
                        
                    },
                };
                var authProvider = new FirebaseAuthClient(config);
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password, UserName);
                await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }
        }
    }
}