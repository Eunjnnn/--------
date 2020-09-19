namespace WPF.ViewModels.Interfaces.Process.Tabs
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using WPF.ViewModels.Interfaces.Process.Entities;

    internal interface IProcessTabViewModel<T> : IViewModelBase
            where T : class, IProcessViewModel
    {
        IObservableCollection<T> Processes { get; }

        IObservableCollection<T> SelectedProcesses { get; }

        void AddProcesses(IEnumerable<T> processes);
    }
}