using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabsV04.DAL.Entities
{
    public class TourGroup
    {
        public int TourGroupId { get; set; }
        public string GroupName { get; set; }

        public List<Tour> Tours { get; set; }
    }
}
