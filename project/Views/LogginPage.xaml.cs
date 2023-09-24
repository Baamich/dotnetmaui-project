namespace project.Views;

public partial class LogginPage : ContentPage
{
    public LogginPage()
    {
        InitializeComponent();
    }

    private async void SignUpButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUpPage());
    }
}
