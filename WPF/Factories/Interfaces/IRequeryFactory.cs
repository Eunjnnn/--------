namespace WPF.Factories.Interfaces
{
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    internal interface IRequeryFactory
    {
        IRequeryViewModel MakeRequeryViewModel(IVideoViewModel videoViewModel, QueryResult queryResult);
    }
}