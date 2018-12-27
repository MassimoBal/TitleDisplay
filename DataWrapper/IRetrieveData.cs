using DataRepository;
using System.Collections.Generic;

namespace DataWrapper
{
    public interface IRetrieveData
    {
        void RefreshData();
        Dictionary<string, WorksById> WorksByIds { get; }
    }
}
