using TestProject.Common.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Interfaces.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<ItemDTO> GetPageItems(int pageStart, int pageSize);
        int GetNumberOfTotalItems();
    }
}
