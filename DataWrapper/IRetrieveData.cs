using DataRepository;
using System.Collections.Generic;

namespace DataWrapper
{
    public interface IRetrieveData
    {
        void GetData();
        Dictionary<string, WorksById> WorksByIds { get; }
    }
}
