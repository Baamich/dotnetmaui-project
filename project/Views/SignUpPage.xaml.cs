using System;
using project.Models;

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

    private void SignUpButton_Clicked(Object sender, EventArgs e)
    {
        CheckPassword();
    }
    
    private async void ReturnButton_Clicked(Object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
    }    
}
