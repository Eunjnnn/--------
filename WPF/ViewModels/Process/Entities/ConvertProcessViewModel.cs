namespace WPF.ViewModels.Process.Entities
{
    using WPF.Models;
    using WPF.Utilities.Processing;
    using WPF.ViewModels.Interfaces;
    using WPF.ViewModels.Interfaces.Process.Entities;

    internal class ConvertProcessViewModel : ActiveProcessViewModel, IConvertProcessViewModel
    {
        public ConvertProgress ConvertProgress { get; private set; }

        public void Initialise(IVideoViewModel videoViewModel, ConvertProcess process, ConvertProgress convertProgress)
        {
            Initialise(videoViewModel, process);
            ConvertProgress = convertProgress;
        }
    }
}