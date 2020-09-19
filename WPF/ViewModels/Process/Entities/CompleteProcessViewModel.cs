namespace WPF.ViewModels.Process.Entities
{
    using WPF.Models.Download;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal class CompleteProcessViewModel : ProcessViewModel, ICompleteProcessViewModel
    {
        public void Initialise(IVideoViewModel videoViewModel, DownloadState downloadState)
        {
            Initialise(videoViewModel);
            DownloadState = downloadState;
        }
    }
}