using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lap456.Models;

namespace lap456.ViewModel
{
    public class CourseViewModelController : Controller
    {
        // GET: CourseViewNodel
        public class CourseViewModel
        {
            internal List<Category> Caterories;

            public string Place { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }

        }
    }
}