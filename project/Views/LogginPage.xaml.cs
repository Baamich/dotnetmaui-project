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
    }

    private bool IsDataCorrect()
    {
        ErrorLabel.Text = "";
        if (EmailEntry.Text != loginDataFileHandler.emailLine || PasswordEntry.Text != loginDataFileHandler.passwordLine)
        {
            ErrorLabel.Text = "Email or password are incorrect";
            return false;
        }
        return true;
    }
}
