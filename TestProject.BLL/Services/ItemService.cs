using TestProject.Common.Interfaces.Repositories;
using TestProject.Common.Interfaces.Services;
using TestProject.Common.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.BLL.Services
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public ItemResult GetPageItems(int pageStart, int pageSize)
        {
            return new ItemResult()
            {
                Items = _itemRepository.GetPageItems(pageStart, pageSize),
                NumberOfTotalItems = _itemRepository.GetNumberOfTotalItems()
            };

        }
    }
}
