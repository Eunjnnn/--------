namespace WPF.ViewModels.Interfaces
{
    using WPF.ViewModels.Interfaces.Process;

    internal interface IMainViewModel : IViewModelBase
    {
        IQueryViewModel QueryViewModel { get; }

        IProcessTabsViewModel ProcessTabsViewModel { get; }
    }
}