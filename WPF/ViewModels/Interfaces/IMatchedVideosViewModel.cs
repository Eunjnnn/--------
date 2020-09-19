namespace WPF.ViewModels.Interfaces
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using WPF.Models;

    internal interface IMatchedVideosViewModel : IViewModelBase
    {
        IObservableCollection<IMatchedVideoViewModel> Videos { get; }

        IObservableCollection<IMatchedVideoViewModel> SelectedVideos { get; }

        void Load(IEnumerable<QueryResult> videos);

        void DownloadSelected();
    }
}