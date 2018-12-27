using DataWrapper;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class DataReaderTests
    {
        private DataReader dr;
        private const string goodJsonPartialPath = ".\\Repository\\GoodJson.json";
        private const string badJsonPartialPath = ".\\Repository\\BadJson.json";
        public DataReaderTests()
        {
        }

        [SetUp]
        public void Setup()
        {
            dr = new DataReader("some dummy path");
        }

        [Test]
        public void TestBadFileNameDataSource()
        {
            Assert.Throws<FileNotFoundException>(() => dr.ReadJson("a file"));
        }
        [Test]
        public void TestNoFileNameDataSource()
        {
            Assert.Throws<System.ArgumentNullException>(() => dr.ReadJson(null));
        }
        [Test]
        public void TestWithGoodJsonData()
        {
            var applicationPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var getFullPathFileName = Path.GetFullPath(applicationPath + goodJsonPartialPath);
            var result = dr.ReadJson(getFullPathFileName);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.WorksById);
        }
        [Test]
        public void TestWithBadJsonData()
        {
            var applicationPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var getFullPathFileName = Path.GetFullPath(applicationPath + badJsonPartialPath);
            var result = dr.ReadJson(getFullPathFileName);
            Assert.Throws<System.Exception>(() => dr.ReadJson(getFullPathFileName));
        }
    }
}