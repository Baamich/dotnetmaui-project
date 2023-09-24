namespace project.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
        if (Password != Password2)
        {
            ErorPassword.Text = "Password does't match ";
        }
        else if (Password == Password2)
        {
            ErorPassword.Text = "";
        }
    }

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

}
