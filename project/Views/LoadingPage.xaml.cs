﻿using project.Models;

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
            await Shell.Current.GoToAsync(AppRoutes.singUpPageRoute); //temp value for test
        }
        else
        {
            await Shell.Current.GoToAsync(AppRoutes.logginPageRoute); //temp value for test
        }
        base.OnNavigatedTo(eventArgs);
    }

    private async Task<bool> isAuntificated()
    {
        await Task.Delay(2000);
        var hasAuth = await SecureStorage.GetAsync(AppRoutes.secStorageKey);
        return !(hasAuth == null);
    }
}
