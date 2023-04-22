using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Newtonsoft.Json;
using thangbillapp.Utils;
using thangbillapp.Views;

namespace thangbillapp.ViewModels
{
    public partial class SignInViewModel: ObservableObject
    {
        [ObservableProperty]
        string imagePass;

        [ObservableProperty]
        bool isShowPassWord;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        public SignInViewModel()
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
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(Email, Password);
                var user = auth.User;
                var uid = user.Uid;
                var name = user.Info.DisplayName; // more properties are available in user.Info
                var refreshToken = user.Credential.RefreshToken;
                var serializedContent = JsonConvert.SerializeObject(user);
                Preferences.Set("userLogin", serializedContent);
                await Shell.Current.GoToAsync(nameof(HomePage));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }

        }

        [RelayCommand]
        public async Task SignUp()
        {
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        }
    }
}
