using System.Collections.Generic;
using DataRepository;
using DataWrapper;

namespace BookTitlesDisplay.Models
{
    public class DataModel
    {
        private IRetrieveData _dataAccessor;
        public Dictionary<string, WorksById> Works {  get; private set;  }


        public DataModel(IRetrieveData retrieveData)
        {
            _dataAccessor = retrieveData;
            Populate();
        }

        public void Populate()
        {
            _dataAccessor.RefreshData();
            Works = _dataAccessor.WorksByIds;
        }
    }
}
