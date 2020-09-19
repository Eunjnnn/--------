namespace WPF.ViewModels.Interfaces
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using WPF.Models;

    internal interface IRequeryViewModel : IViewModelBase
    {
        IVideoViewModel NewVideo { get; }

        IObservableCollection<IMatchedVideoViewModel> Results { get; }

        string Query { get; set; }

        IEnumerable<IResult> Search();

        void Initialise(IVideoViewModel requeryTarget, QueryResult queryResult);
    }
}