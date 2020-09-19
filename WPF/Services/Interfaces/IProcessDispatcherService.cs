namespace WPF.Services.Interfaces
{
    using System.Collections.Generic;

    using WPF.ViewModels.Interfaces;

    internal interface IProcessDispatcherService
    {
        void Dispatch(IEnumerable<IViewModelBase> viewModels);

        void Dispatch(IViewModelBase viewModel);
    }
}