namespace WPF.ViewModels.Process.Tabs
{
    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Utilities;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process.Entities;
    using WPF.ViewModels.Interfaces.Process.Tabs;

    internal class CompletedTabViewModel : ProcessTabViewModel<ICompleteProcessViewModel>, ICompletedTabViewModel
    {
        public CompletedTabViewModel(IEventAggregator eventAggregator, IActionButtonFactory actionButtonFactory) : base(eventAggregator)
        {
            Buttons = new IActionButtonViewModel[]
            {
                    actionButtonFactory.MakeActionButtonViewModel("Delete", "Remove", () =>
                    {
                        if (SelectedProcesses.Count == 0)
                        {
                            Processes.Clear();
                            return;
                        }

                        Processes.RemoveRange(SelectedProcesses);
                    })
            };
        }

        private protected override bool CanAccept(ProcessTransferType processTransferType)
        {
            return processTransferType == ProcessTransferType.Complete;
        }
    }
}