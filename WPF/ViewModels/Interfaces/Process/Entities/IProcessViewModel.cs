namespace WPF.ViewModels.Interfaces.Process.Entities
{
    using WPF.Models.Download;

    internal interface IProcessViewModel : IViewModelBase
    {
        IVideoViewModel VideoViewModel { get; }

        DownloadState DownloadState { get; set; }
    }
}