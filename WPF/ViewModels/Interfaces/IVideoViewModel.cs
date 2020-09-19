namespace WPF.ViewModels.Interfaces
{
    using WPF.Models;

    internal interface IVideoViewModel : IViewModelBase
    {
        YouTubeVideo Video { get; set; }
    }
}