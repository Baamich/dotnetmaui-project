﻿namespace project.Views;

public partial class LoadingPage : ContentPage
{
    private string secStorageKey = "hasAuth";

    public LoadingPage()
    {
        InitializeComponent();
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs eventArgs)
    {
        if (await isAuntificated())
        {
            await Shell.Current.GoToAsync("///singup"); //temp value for test
        }
        else
        {
            await Shell.Current.GoToAsync("///loggin"); //temp value for test
        }
        base.OnNavigatedTo(eventArgs);
    }

    private async Task<bool> isAuntificated()
    {
        await Task.Delay(2000);
        var hasAuth = await SecureStorage.GetAsync(secStorageKey);
        return !(hasAuth == null);
    }
}
