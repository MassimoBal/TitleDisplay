using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookTitlesDisplay.Models;
using DataWrapper;
using PagedList;
using DataRepository;
using System.Web.Configuration;
using System.IO;

namespace BookTitlesDisplay.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataModel _dataModel;
        private List<WorksById> works;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
                                                
        public HomeController()
        {
            var applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            string partialPath = WebConfigurationManager.AppSettings["dataSource"];
            var jsonFile = Path.GetFullPath(Path.Combine(applicationPath, partialPath));
            IRetrieveData ird = new DataReader(jsonFile);
            _dataModel = new DataModel(ird);
            works = _dataModel.Works.Select(kvp => kvp.Value).ToList();
        }
                                                
        public ViewResult Index(string currentFilter, string searchString , int? page, int startIndex = 0)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                works = works.Where(w => w.Title.TitleText.ToLower().Contains(searchString.ToLower())).ToList();
                ViewBag.ListOfWorks = works;
            }
                              
            ViewBag.CurrentFilter = searchString;
                                                
            int pageSize = 10;
            int pageIndex = (page ?? 1);

            return View(works.ToPagedList(pageIndex, pageSize));
        }
    }
}