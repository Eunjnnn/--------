namespace WPF.Factories
{
    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Models;
    using WPF.Models.Download;
    using WPF.Services.Interfaces;
    using WPF.Utilities.Processing;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal class ProcessFactory : IProcessFactory
    {
        private readonly Settings _settings;

        public ProcessFactory(ISettingsService settingsService)
        {
            _settings = settingsService.Settings;
        }

        public IDownloadProcessViewModel MakeDownloadProcessViewModel(IVideoViewModel videoViewModel)
        {
            IDownloadProcessViewModel downloadProcessViewModel = IoC.Get<IDownloadProcessViewModel>();

            DownloadProgress downloadProgress = new DownloadProgress();

            downloadProcessViewModel.Initialise(videoViewModel, new DownloadProcess(downloadProgress, videoViewModel.Video, _settings), downloadProgress);

            return downloadProcessViewModel;
        }

        public IConvertProcessViewModel MakeConvertProcessViewModel(IVideoViewModel videoViewModel, ConvertProcess process, ConvertProgress progress)
        {
            IConvertProcessViewModel convertProcessViewModel = IoC.Get<IConvertProcessViewModel>();
            convertProcessViewModel.Initialise(videoViewModel, process, progress);

            return convertProcessViewModel;
        }

        public ICompleteProcessViewModel MakeCompleteProcessViewModel(IVideoViewModel videoViewModel, DownloadState downloadState)
        {
            ICompleteProcessViewModel completeProcessViewModel = IoC.Get<ICompleteProcessViewModel>();
            completeProcessViewModel.Initialise(videoViewModel, downloadState);

            return completeProcessViewModel;
        }
    }
}