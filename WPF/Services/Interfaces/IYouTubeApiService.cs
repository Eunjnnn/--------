namespace WPF.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WPF.Models;

    internal interface IYouTubeApiService : IDisposable
    {
        Task<IEnumerable<QueryResult>[]> QueryVideos(IEnumerable<QueryResult> query);

        Task<IEnumerable<QueryResult>> QueryManyVideos(QueryResult query);
    }
}