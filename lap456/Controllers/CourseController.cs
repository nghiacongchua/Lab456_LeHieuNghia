using lap456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static lap456.ViewModel.CourseViewModelController;

namespace lap456.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Course
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Caterories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}