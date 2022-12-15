using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlackLotus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StockController : Controller
    {

        private readonly IStockRepo stockRepo;
        private readonly IMapper mapper;

        public StockController(IStockRepo _stockRepo, IMapper _mapper)

        {
            stockRepo = _stockRepo;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<StockReadDTO>> GetStock()
        {
            var stock = stockRepo.GetStock();
            return Ok(mapper.Map<IEnumerable<StockReadDTO>>(stock));
        }
        [HttpGet("{stockId}", Name = "GetStockById")]
        public ActionResult<StockReadDTO> GetStockById(int stockId)
        {
            var stock = stockRepo.GetStockById(stockId);
            if (stock != null)
                return Ok(mapper.Map<StockReadDTO>(stock));
            else
                return NotFound();
        }


        [HttpPost]
        public ActionResult<StockCreateDTO> CreateStock(StockCreateDTO stock)
        {
            var stockModel = mapper.Map<Stock>(stock);
            stockRepo.createStock(stockModel);
            stockRepo.Save();

            var newStock = mapper.Map<StockReadDTO>(stockModel);
            return CreatedAtRoute(nameof(GetStockById), new { stockId = newStock.stockId }, newStock);

        }
        [HttpDelete("{stockId}")]

        public ActionResult Delete(int stockId)
        {
            var stockToDelete = stockRepo.GetStockById(stockId);
            if (stockToDelete == null)
                return NotFound();
            stockRepo.delete(stockToDelete);
            return Ok();

        }
        [HttpPut]
        public ActionResult Update(int stockId, StockCreateDTO stock)
        {
            var updateStock = mapper.Map<Stock>(stock);
            updateStock.stockId = stockId;
            if (!stockRepo.update(updateStock))
                return NotFound();
            else
                return Ok();

        }
    }
}
