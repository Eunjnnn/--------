namespace WPF.ViewModels.Interfaces.Process.Entities
{
    using WPF.Models;
    using WPF.Utilities.Processing;

    internal interface IConvertProcessViewModel : IActiveProcessViewModel
    {
        ConvertProgress ConvertProgress { get; }

        void Initialise(IVideoViewModel videoViewModel, ConvertProcess process, ConvertProgress convertProgress);
    }
}