namespace WPF.ViewModels.Interfaces.Process.Entities
{
    using WPF.Models.Download;

    internal interface ICompleteProcessViewModel : IProcessViewModel
    {
        void Initialise(IVideoViewModel videoViewModel, DownloadState downloadState);
    }
}