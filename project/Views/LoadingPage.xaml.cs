namespace project.Views;

public partial class LoadingPage : ContentPage
{   
    public LoadingPage()
    {
        InitializeComponent();
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs eventArgs)
    {
        if (await isAuntificated())
        {
            await Shell.Current.GoToAsync(AppRoutes.mainPageRoute);
        }
        else
        {
            await Shell.Current.GoToAsync(AppRoutes.logginPageRoute);
        }
        base.OnNavigatedTo(eventArgs);
    }

    private async Task<bool> isAuntificated()
    {
        await LoadingScreenHandler();
        var hasAuth = await SecureStorage.GetAsync(AppRoutes.secStorageKey);
        return !(hasAuth == null);
    }

    private async Task LoadingScreenHandler()
    {
        await Task.Delay(1000);
        LoadingInfoText.Text = "Checking data integrity...";
        await Task.Delay(3000);
        LoadingInfoText.Text = "Loading data...";
        await Task.Delay(2000);
    }
}
