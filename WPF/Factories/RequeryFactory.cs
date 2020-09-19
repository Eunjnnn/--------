namespace WPF.Factories
{
    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    internal class RequeryFactory : IRequeryFactory
    {
        public IRequeryViewModel MakeRequeryViewModel(IVideoViewModel videoViewModel, QueryResult queryResult)
        {
            IRequeryViewModel requeryViewModel = IoC.Get<IRequeryViewModel>();
            requeryViewModel.Initialise(videoViewModel, queryResult);

            return requeryViewModel;
        }
    }
}