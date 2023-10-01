namespace project.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void DataList_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {

    }

    async void Settings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(AppRoutes.settingsPageRoute);
    }

    void Logs_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    void addItemButton_Clicked(System.Object sender, System.EventArgs e)
    {

    }
}
