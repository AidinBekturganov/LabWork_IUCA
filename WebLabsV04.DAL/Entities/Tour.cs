using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabsV04.DAL.Entities
{
    public class Tour
    {
        public int TourId { get; set; } // id 
        public string TourName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } // имя файла изображения
                                          // Навигационные свойства
        /// <summary>

        /// </summary>
        public int TourGroupId { get; set; }
        public TourGroup Group { get; set; }
    }


}

