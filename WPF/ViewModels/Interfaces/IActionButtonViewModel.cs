namespace WPF.ViewModels.Interfaces
{
    using WPF.Models;

    internal interface IActionButtonViewModel : IViewModelBase
    {
        ActionButton ActionButton { get; }

        void Initialise(ActionButton actionButton);
    }
}