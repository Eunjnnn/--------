namespace WPF.Factories.Interfaces
{
    using System;

    using WPF.ViewModels.Interfaces;

    internal interface IActionButtonFactory
    {
        IActionButtonViewModel MakeActionButtonViewModel(string image, string name, Action action);
    }
}