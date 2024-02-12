using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class MustReadViewModel
    {
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<MustReadViewModelData> data { get; set; }
    }
    public class MustReadViewModelData
    {
        public int mustReadId { get; set; }
        public string icon { get; set; }
        public string h1Text { get; set; }
        public string h2Text { get; set; }
        public string htmlContent { get; set; }
    }
}
