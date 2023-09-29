using project.Models;

namespace project.Views;

public partial class LogginPage : ContentPage
{
    LoginDataFileHandler loginDataFileHandler;

    public LogginPage()
    {
        InitializeComponent();
        loginDataFileHandler = new LoginDataFileHandler();
    }
   
    
    private async void SignUpButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.singUpPageRoute);
    }

    private async void SignInButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await loginDataFileHandler.ReadLoginData();
        if (IsDataCorrect())
        {
            await SecureStorage.SetAsync(AppRoutes.secStorageKey, value:"true");
            await Shell.Current.GoToAsync(AppRoutes.loadingPageRoute);
        }
        else
        {
            ErrorLabel.Text = "Email or password are incorrect";
        }
    }

    private bool IsDataCorrect()
    {
        ErrorLabel.Text = "";
        if (EmailEntry.Text != loginDataFileHandler.emailLine || PasswordEntry.Text != loginDataFileHandler.passwordLine) return false;
        else return EmailEntry.Text == loginDataFileHandler.emailLine && PasswordEntry.Text == loginDataFileHandler.passwordLine;
    }
}
