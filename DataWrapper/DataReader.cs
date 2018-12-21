using System;
using System.Collections.Generic;
using System.IO;
using DataRepository;
using Newtonsoft.Json;

namespace DataWrapper
{
    public class DataReader : IRetrieveData
    {
      //  private Dictionary<string, WorksById> _worksById;
        private RootObject dataContent;

        public DataReader()
        {
            dataContent = null;
        }
        public RootObject ReadJson(string jsonFile)
        {
            try
            {
                string json = File.ReadAllText(jsonFile);
                dataContent = Welcome.FromJson(json);
                WorksByIds = dataContent.WorksById;
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
            }
            catch (JsonException exception)
            {
                Console.WriteLine(exception);
            }

            return dataContent;

        }

        public void GetData()
        {
            var applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            var getFullPathFileName = Path.GetFullPath(applicationPath + @"\Repository\Graph-Example.json");
            ReadJson(getFullPathFileName);
        }

        public Dictionary<string, WorksById> WorksByIds { get; private set; }    
    }
}
