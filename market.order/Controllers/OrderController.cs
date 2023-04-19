using Microsoft.AspNetCore.Mvc;
using market.order.Services;
using market.order.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace market.order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly I_OrderService _OrderService;

        public OrderController(I_OrderService OrderService)
        {
            _OrderService = OrderService?? throw new ArgumentNullException(nameof(OrderService));
        }

        // GET: api/<ItemController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_OrderService.GetItems());
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _OrderService.GetItem(id) != null ? Ok(_OrderService.GetItem(id)) : NotFound();
        }

// POST api/<ItemController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Order item)
        {
            return Ok(_OrderService.AddItem(item));
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Order item)
        {
            return Ok(_OrderService.UpdateItem(item));
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _OrderService.DeleteItem(id);

            return result == true ? Ok($"item with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the sitem with ID:{id}.");
        }
    }
}
