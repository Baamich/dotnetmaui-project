using System;
using project.Models;

namespace project.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();     
    }    

    private void SignUpButton_Clicked(Object sender, EventArgs e)
    {
        CheckPassword();
    }

    private void CheckPassword()
    {
        ErrorLabel.Text = null;
        if (PasswordEntry.Text != RepeatPasswordEntry.Text)
        {
            ErrorLabel.Text = "Password does't match.";
        }
        else if(PasswordEntry.Text.Length < 4)
        {
            ErrorLabel.Text = "Password must be longer than 4 digits.";
        }
    }

    private async void ReturnButton_Clicked(Object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
    }    
}
