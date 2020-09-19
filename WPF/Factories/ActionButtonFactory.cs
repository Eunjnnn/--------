namespace WPF.Factories
{
    using Caliburn.Micro;

    using WPF.Factories.Interfaces;
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    using Action = System.Action;

    internal class ActionButtonFactory : IActionButtonFactory
    {
        public IActionButtonViewModel MakeActionButtonViewModel(string image, string name, Action action)
        {
            IActionButtonViewModel actionButtonViewModel = IoC.Get<IActionButtonViewModel>();
            actionButtonViewModel.Initialise(new ActionButton(image, name, action));

            return actionButtonViewModel;
        }
    }
}