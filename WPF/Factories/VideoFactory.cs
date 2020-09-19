namespace WPF.Factories
{
    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    internal class VideoFactory : IVideoFactory
    {
        public IVideoViewModel MakeVideoViewModel(YouTubeVideo video)
        {
            IVideoViewModel videoViewModel = IoC.Get<IVideoViewModel>();
            videoViewModel.Video = video;

            return videoViewModel;
        }

        public IMatchedVideoViewModel MakeMatchedVideoViewModel(QueryResult queryResult)
        {
            IMatchedVideoViewModel matchedVideoViewModel = IoC.Get<IMatchedVideoViewModel>();
            matchedVideoViewModel.Initialise(MakeVideoViewModel(queryResult.MatchedVideo), queryResult);

            return matchedVideoViewModel;
        }
    }
}