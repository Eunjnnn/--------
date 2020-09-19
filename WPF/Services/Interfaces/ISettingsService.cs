namespace WPF.Services.Interfaces
{
    using WPF.Models;

    internal interface ISettingsService
    {
        Settings Settings { get; }

        void Save();
    }
}