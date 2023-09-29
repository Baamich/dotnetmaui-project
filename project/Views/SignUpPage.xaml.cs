using project.Models;

namespace project.Views;

public partial class SignUpPage : ContentPage
{
    LoginDataFileHandler loginDataFileHandler;

    public SignUpPage()
    {
        InitializeComponent();
        loginDataFileHandler = new LoginDataFileHandler();
    }    

    private async void SignUpButton_Clicked(Object sender, EventArgs e)
    {
        if (HandleErrorLabel())
        {            
            await loginDataFileHandler.WriteLoginData(EmailEntry.Text, PasswordEntry.Text);
            await DisplayAlert(title:"Successfull registred", message:"Now return to previous page and login to the system.", cancel:"Return");
            await Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
        }
    }

    private bool HandleErrorLabel()
    {
        ErrorLabel.Text = null;
        if (!EmailEntry.Text.Contains("@gmail.com"))
        {
            ErrorLabel.Text = "Enter email in right format.";
            return false;
        }
        if (PasswordEntry.Text != RepeatPasswordEntry.Text)
        {
            ErrorLabel.Text = "Password does't match.";
            return false;
        }
        if (PasswordEntry.Text.Length < 4)
        {
            ErrorLabel.Text = "Password must be longer than 4 digits.";
            return false;
        }
        return true;
    }

    private async void ReturnButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
    }
}
