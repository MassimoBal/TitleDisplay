using System;
using System.Collections.Generic;
using System.IO;
using DataRepository;
using Newtonsoft.Json;

namespace DataWrapper
{
    public class DataReader : IRetrieveData
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DataReader));
        private RootObject dataContent;
        private readonly string jsonFile;

        public DataReader(string jsonFile)
        {
            dataContent = null;
            this.jsonFile = jsonFile;
        }
        public RootObject ReadJson(string jsonFile)
        {
            try
            {
                string json = File.ReadAllText(jsonFile);
                dataContent = Welcome.FromJson(json);
                WorksByIds = dataContent.WorksById;
                return dataContent;
            }
            catch (FileNotFoundException exception)
            {
                log.Error("File not found", exception);
                throw;
            }
            catch (Exception exception)
            {
                log.Error("Unknown problem: ", exception);
                throw;
            }
        }

        public void RefreshData()
        {
            ReadJson(jsonFile);
        }

        public Dictionary<string, WorksById> WorksByIds { get; private set; }    
    }
}
