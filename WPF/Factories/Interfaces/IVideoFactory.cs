namespace WPF.Factories.Interfaces
{
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    internal interface IVideoFactory
    {
        IVideoViewModel MakeVideoViewModel(YouTubeVideo video);

        IMatchedVideoViewModel MakeMatchedVideoViewModel(QueryResult queryResult);
    }
}