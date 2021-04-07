using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLabsV04.DAL.Entities;

namespace LabWork_IUCA.Controllers
{
    public class ProductController : Controller
    {

        List<Tour> _tours;

        List<TourGroup> _tourGroups;
        public IActionResult Index()
        {
            
            return View(_tours);
        }

        public ProductController()
        {
            SetupData();
        }
      
        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _tourGroups = new List<TourGroup>
                {
                new TourGroup {TourGroupId=1, GroupName="Горы"},
                new TourGroup {TourGroupId=2, GroupName="Озера"},
                new TourGroup {TourGroupId=3, GroupName="Ледники"},
                new TourGroup {TourGroupId=4, GroupName="Пляжи"},
                new TourGroup {TourGroupId=5, GroupName="Леса"},
                new TourGroup {TourGroupId=6, GroupName="Города"}
                };
            _tours = new List<Tour>
                {
                new Tour {TourId = 1, TourName="Аламедин",
                Description="Очень красиво", TourGroupId=1, Image="Горы.jpg" },
                new Tour {TourId = 2, TourName="Пик Ленина",
                Description="Восхитительно", TourGroupId=3, Image="пик.jpg" },
                new Tour {TourId = 3, TourName="Сон-Кол",
                Description="Волшебно", TourGroupId=2, Image="Озеро.jpg" },
                new Tour {TourId = 4, TourName="Золотые пески",
                Description="Отдохнуть на все сто", TourGroupId=4, Image="ик.jpg" },
                new Tour {TourId = 5, TourName="Ала-Арча",
                Description="Сказочно", TourGroupId=5, Image="лес.jpg" },
                new Tour {TourId = 6, TourName="Ош",
                Description="Пропитан историей", TourGroupId=3, Image="ош.jpg" }

                };
        }
    }
}
