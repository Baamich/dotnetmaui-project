namespace project.Views;

public partial class LogginPage : ContentPage
{
    private string secStorageKey = "hasAuth"; //test, chanhe to property ot other thing

    public LogginPage()
    {
        InitializeComponent();
    }

    private async void SignUpButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUpPage());
    }


    //Check loading page logic
    private async void SignInButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if (IsDataCorrect())
        {
            await SecureStorage.SetAsync(secStorageKey, "true");
            await Shell.Current.GoToAsync("///loading");
        }
    }

    private bool IsDataCorrect()
    {
        return EmailEntry.Text == "admin" && PasswordEntry.Text == "admin";
    }
}
