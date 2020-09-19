namespace WPF.ViewModels.Interfaces.Process.Entities
{
    using WPF.Utilities.Processing;

    internal interface IActiveProcessViewModel : IProcessViewModel
    {
        MonitoredProcess Process { get; }
    }
}