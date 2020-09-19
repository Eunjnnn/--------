namespace WPF.Services.Interfaces
{
    using System.Collections.Generic;

    using WPF.Utilities.Processing;

    internal interface IDownloadService
    {
        void QueueDownloads(IEnumerable<DownloadProcess> downloads);
    }
}