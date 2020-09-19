namespace WPF.ViewModels.Process
{
    using Caliburn.Micro;

    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process;
    using WPF.ViewModels.Interfaces.Process.Tabs;

    internal class ProcessTabsViewModel : Conductor<IViewModelBase>.Collection.OneActive, IProcessTabsViewModel
    {
        public ProcessTabsViewModel(
                IDownloadsTabViewModel downloadsTabViewModel,
                IConversionsTabViewModel conversionsTabViewModel,
                ICompletedTabViewModel completedTabViewModel
                )
        {
            Items.Add(downloadsTabViewModel);
            Items.Add(conversionsTabViewModel);
            Items.Add(completedTabViewModel);
        }
    }
}