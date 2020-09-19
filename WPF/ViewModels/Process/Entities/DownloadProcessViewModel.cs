namespace WPF.ViewModels.Process.Entities
{
    using WPF.Models.Download;
    using WPF.Utilities.Processing;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal class DownloadProcessViewModel : ActiveProcessViewModel, IDownloadProcessViewModel
    {
        public DownloadProgress DownloadProgress { get; private set; }

        public void Initialise(IVideoViewModel videoViewModel, DownloadProcess process, DownloadProgress downloadProgress)
        {
            Initialise(videoViewModel, process);
            DownloadProgress = downloadProgress;
        }
    }
}