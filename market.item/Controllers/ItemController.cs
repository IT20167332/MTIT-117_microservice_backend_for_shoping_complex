using Microsoft.AspNetCore.Mvc;
using market.item.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace market.item.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly I_ItemService _ItemService;

        public ItemController(I_ItemService itemService)
        {
            _ItemService = itemService??throw new ArgumentNullException(nameof(itemService));
        }

        // GET: api/<ItemController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ItemService.GetItems());
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _ItemService.GetItem(id) != null ? Ok(_ItemService.GetItem(id)) : NotFound();
        }

        // POST api/<ItemController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Item item)
        {
            return Ok(_ItemService.AddItem(item));
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Item item)
        {
            return Ok(_ItemService.UpdateItem(item));
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _ItemService.DeleteItem(id);

            return result == true ? Ok($"item with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the sitem with ID:{id}.");
        }
    }
}
