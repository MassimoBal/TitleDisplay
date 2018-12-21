using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookTitlesDisplay.Models;
using DataWrapper;
using PagedList;
using DataRepository;

namespace BookTitlesDisplay.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataModel _dataModel;
        private List<WorksById> works;
        public HomeController()
        {
            IRetrieveData ird = new DataReader();
            _dataModel = new DataModel(ird);
            works = _dataModel.Works.Select(kvp => kvp.Value).ToList();
        }

        public ActionResult OldIndex(string searchString)
        {
            var works = _dataModel.Works.Select(kvp => kvp.Value).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                works = works.Where(w => w.Title.TitleText.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return View(works);
        }

        public ViewResult Index(string currentFilter, string searchString , int? page, int startIndex = 0)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                works = works.Where(w => w.Title.TitleText.ToLower().Contains(searchString.ToLower())).ToList();
            }
            else
            {
                searchString = currentFilter;
                page = 1;
            }
            
            ViewBag.CurrentFilter = searchString;


            int pageSize = 10;
            int pageNumber = (page ?? 1);

            //return View(works.ToPagedList(pageNumber, pageSize));
            return View(works);
        }
    }
}