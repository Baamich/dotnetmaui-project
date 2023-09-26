using project.Models;

namespace project.Views;

public partial class LogginPage : ContentPage
{   
    public LogginPage()
    {
        InitializeComponent();
    }

    private async void SignUpButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.singUpPageRoute);
    }
    
    private async void SignInButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if (IsDataCorrect())
        {
            await SecureStorage.SetAsync(AppRoutes.secStorageKey, value:"true");
            await Shell.Current.GoToAsync(AppRoutes.loadingPageRoute);
        }
    }

    private bool IsDataCorrect()
    {
        return EmailEntry.Text == "admin" && PasswordEntry.Text == "admin"; //test data
    }
}
