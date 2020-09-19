namespace WPF.Utilities
{
    using System.Collections.Generic;

    using WPF.ViewModels.Interfaces.Process.Entities;

    internal class ProcessTransferMessage
    {
        internal ProcessTransferMessage(ProcessTransferType processTransferType, IEnumerable<IProcessViewModel> processes)
        {
            ProcessTransferType = processTransferType;
            Processes = processes;
        }

        internal ProcessTransferType ProcessTransferType { get; }

        internal IEnumerable<IProcessViewModel> Processes { get; }
    }
}