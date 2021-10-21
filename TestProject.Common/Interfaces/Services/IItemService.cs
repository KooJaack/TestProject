using TestProject.Common.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Interfaces.Services
{
    public interface IItemService
    {
        ItemResult GetPageItems(int pageStart, int PageSize);
    }
}
