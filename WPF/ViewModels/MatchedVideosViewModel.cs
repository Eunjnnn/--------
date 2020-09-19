namespace WPF.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Models;
    using WPF.Services.Interfaces;
    using WPF.ViewModels.Interfaces;

    internal class MatchedVideosViewModel : ViewModelBase, IMatchedVideosViewModel
    {
        private readonly IVideoFactory _videoFactory;

        private readonly IProcessDispatcherService _processDispatcherService;

        public MatchedVideosViewModel(IVideoFactory videoFactory, IProcessDispatcherService processDispatcherService)
        {
            _videoFactory = videoFactory;
            _processDispatcherService = processDispatcherService;
        }

        public IObservableCollection<IMatchedVideoViewModel> Videos { get; } = new BindableCollection<IMatchedVideoViewModel>();

        public IObservableCollection<IMatchedVideoViewModel> SelectedVideos { get; } = new BindableCollection<IMatchedVideoViewModel>();

        public void Load(IEnumerable<QueryResult> videos)
        {
            SelectedVideos.Clear();
            Videos.Clear();

            Videos.AddRange(videos.Select(_videoFactory.MakeMatchedVideoViewModel));
        }

        public void DownloadSelected()
        {
            _processDispatcherService.Dispatch(SelectedVideos.Select(matchedVideo => matchedVideo.VideoViewModel));
        }
    }
}