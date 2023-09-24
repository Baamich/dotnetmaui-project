namespace project.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
