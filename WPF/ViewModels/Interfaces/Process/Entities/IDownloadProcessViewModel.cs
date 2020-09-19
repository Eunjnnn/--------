namespace WPF.ViewModels.Interfaces.Process.Entities
{
    using WPF.Models.Download;
    using WPF.Utilities.Processing;

    internal interface IDownloadProcessViewModel : IActiveProcessViewModel
    {
        DownloadProgress DownloadProgress { get; }

        void Initialise(IVideoViewModel videoViewModel, DownloadProcess process, DownloadProgress downloadProgress);
    }
}