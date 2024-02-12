using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class FilterSettingsDTO
    {
        public int FilterId { get; set; }
        public int FilterValueId { get; set; }
        public int Order { get; set; }

        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateFilterSettingsDTO
    {
        public int FilterSettingId { get; set; }
        public int FilterId { get; set; }
        public int Order { get; set; }
        public int FilterValueId { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class FilterSettingCombinations
    {
        public int FilterValueId { get; set; }
        public int FilterId { get; set; }
        public string FilterValueName { get; set; }
    }
    class IndexData
    {
        public int PropIndex { get; set; }
        public int MaxCount { get; set; }
    }
}
