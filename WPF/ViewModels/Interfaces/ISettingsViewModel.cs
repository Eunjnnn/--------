namespace WPF.ViewModels.Interfaces
{
    using System;

    using WPF.Models;

    internal interface ISettingsViewModel : IViewModelBase
    {
        Settings Settings { get; }

        event EventHandler Closed;
    }
}