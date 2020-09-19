namespace WPF.Factories.Interfaces
{
    using WPF.Models;
    using WPF.Models.Download;
    using WPF.Utilities.Processing;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal interface IProcessFactory
    {
        IDownloadProcessViewModel MakeDownloadProcessViewModel(IVideoViewModel videoViewModel);

        IConvertProcessViewModel MakeConvertProcessViewModel(IVideoViewModel videoViewModel, ConvertProcess process, ConvertProgress progress);

        ICompleteProcessViewModel MakeCompleteProcessViewModel(IVideoViewModel videoViewModel, DownloadState downloadState);
    }
}