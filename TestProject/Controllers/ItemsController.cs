using TestProject.Common.Interfaces.Services;
using TestProject.Common.Models.ItemModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Controllers
{
    [Route("api/items")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public IActionResult Index(int offset = 0, int limit = 15)
        {
            ItemResult items = null;

            if (limit == 0)
                return BadRequest("Limit must be greater than 0.");

            try
            {
                items = _itemService.GetPageItems(offset, limit);
            }
            catch(Exception e)
            {
                return StatusCode(500, "Internal Server Error. Something went Wrong!");
            }

            return Ok(items);
        }
    }
}
