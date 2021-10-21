using TestProject.Common.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Models.ItemModels
{
    public class ItemResult
    {
        public IEnumerable<ItemDTO> Items { get; set; }
        public int NumberOfTotalItems { get; set; }
    }
}
