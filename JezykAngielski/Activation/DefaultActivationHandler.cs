﻿using System;
using System.Threading.Tasks;

using JezykAngielski.Contracts.Services;
using JezykAngielski.ViewModels;

using Microsoft.UI.Xaml;

namespace JezykAngielski.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(MainViewModel).FullName, args.Arguments);

        await Task.CompletedTask;
    }
}
