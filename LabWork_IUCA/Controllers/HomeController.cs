using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabWork_IUCA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }
        public List<ListDemo> _listDemo;

        public HomeController()
        {
            

        }

    }
}
