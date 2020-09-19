namespace WPF.ViewModels.Interfaces
{
    using WPF.Models;

    internal interface IMatchedVideoViewModel : IViewModelBase
    {
        IVideoViewModel VideoViewModel { get; }

        QueryResult QueryResult { get; }

        void Initialise(IVideoViewModel videoViewModel, QueryResult queryResult);
    }
}