namespace WPF.Models.Download
{
    internal enum DownloadState
    {
        Queued,
        Downloading,
        Converting,
        Completed,
        Exited
    }
}