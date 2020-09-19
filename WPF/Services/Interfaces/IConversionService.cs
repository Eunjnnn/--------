namespace WPF.Services.Interfaces
{
    using System.Collections.Generic;

    using WPF.Utilities.Processing;

    internal interface IConversionService
    {
        void QueueConversion(IEnumerable<ConvertProcess> conversions);
    }
}