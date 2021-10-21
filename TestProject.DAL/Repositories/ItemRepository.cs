using ExpressMapper.Extensions;
using TestProject.Common.Interfaces.Repositories;
using TestProject.Common.Models.DTO;
using TestProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject.DAL.Repositories
{
    public class ItemRepository: IItemRepository
    {
        private readonly DataDbContext _context;

        public ItemRepository(DataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ItemDTO> GetPageItems(int pageStart, int pageSize)
        {
            return _context.Items
                .Skip(pageStart)
                .Take(pageSize).ToList()
                .Map<List<Item>, List<ItemDTO>>();
        }

        public int GetNumberOfTotalItems()
        {
            return _context.Items.Count();
        }
    }
}
