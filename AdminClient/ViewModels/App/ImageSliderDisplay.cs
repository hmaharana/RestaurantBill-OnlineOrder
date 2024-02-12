using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class ImageSliderDisplay
    {
        public int ImageSliderId { get; set; }
        public int? CategoryId { get; set; }
        public int? CityId { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int? Order { get; set; }
        public string CityName { get; set; }
        public string CategoryName { get; set; }
        public string OnClickCategoryName { get; set; }

    }
}
