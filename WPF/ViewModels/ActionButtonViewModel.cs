namespace WPF.ViewModels
{
    using WPF.Models;
    using WPF.ViewModels.Interfaces;

    internal class ActionButtonViewModel : ViewModelBase, IActionButtonViewModel
    {
        public ActionButton ActionButton { get; private set; }

        public void Initialise(ActionButton actionButton)
        {
            ActionButton = actionButton;
        }

        public void Clicked()
        {
            ActionButton.Action();
        }
    }
}