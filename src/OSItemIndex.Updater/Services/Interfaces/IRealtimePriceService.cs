﻿using System.Threading.Tasks;
using OSItemIndex.Data;

namespace OSItemIndex.Updater.Services
{
    public interface IRealtimePriceService : IStatefulService
    {
        Task AggregateAsync<T>(string uri, EventSource source) where T: PriceEntity;
    }
}
