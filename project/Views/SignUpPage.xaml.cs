namespace project.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();     
    }

    private void CheckPassword()
    {
        if (PasswordEntry.Text != RepeatPasswordEntry.Text)
        {
            ErrorLabel.Text = "Password does't match";
        }
    }

    private async void SignUpButton_Clicked(System.Object sender, System.EventArgs e)
    {
        CheckPassword();
    }
    
    private async void ReturnButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();
    }    
}
