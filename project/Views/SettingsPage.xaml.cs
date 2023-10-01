namespace project.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    void LogOutButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
    }

    void ReturnButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(AppRoutes.mainPageRoute);
    }
}
