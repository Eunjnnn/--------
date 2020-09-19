namespace WPF.ViewModels.Process.Entities
{
    using WPF.Utilities.Processing;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal abstract class ActiveProcessViewModel : ProcessViewModel, IActiveProcessViewModel
    {
        public MonitoredProcess Process { get; private set; }

        private protected void Initialise(IVideoViewModel videoViewModel, MonitoredProcess process)
        {
            Initialise(videoViewModel);
            Process = process;
        }
    }
}