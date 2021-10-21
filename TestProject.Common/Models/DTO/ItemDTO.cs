using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Models.DTO
{
    public class ItemDTO
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PublicationTime { get; set; }
    }
}
