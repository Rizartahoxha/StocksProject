using Microsoft.AspNetCore.Mvc;
using Student.API.Dto;
using Student.API.Models;
using Student.API.Services;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStocksService _service;

        public StockController(IStocksService service)
        {
            _service = service;
        }

        [HttpGet("All")]
        public IActionResult GetStocks()
        {
            //List of stocks
            var allStocks = _service.GetAllStocks();

            return Ok(allStocks);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetStockById(int id)
        {
            var newStock = _service.GetStockById(id);

            if (newStock == null)
                return NotFound($"Stock with id {id} could not be found.");

            return Ok(newStock);
        }


        [HttpPost]
        public IActionResult AddNewStock ([FromBody] PostStocksDto payload)
        {
            var newStock = _service.AddStock(payload);

            return Ok(newStock);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateStock([FromBody] PutStocksDto payload, int id)
        {
            var updatedStock = _service.UpdateStock(payload, id);

            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteStock(int id)
        {
            _service.DeleteStock(id);

            return Ok();
        }

       
    }
}
