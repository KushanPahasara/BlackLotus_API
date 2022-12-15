using AutoMapper;
using BlackLotus.Data;
using BlackLotus.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackLotus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FlowerController : Controller
    {
        private readonly IFlowerRepo flowerRepo;
        private readonly IMapper mapper;

        public FlowerController(IFlowerRepo _flowerRepo, IMapper _mapper)

        {
            flowerRepo = _flowerRepo;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<FlowerReadDTO>> GetFlowers()
        {
            var flowers = flowerRepo.GetFlowers();
            return Ok(mapper.Map<IEnumerable<FlowerReadDTO>>(flowers));
        }

        [HttpGet("{flowerId}", Name = "GetFlowerByID")]
        public ActionResult<FlowerReadDTO> GetFlowerByID(int flowerId)
        {
            var flower = flowerRepo.GetFlowerById(flowerId);
            if (flower != null)
                return Ok(mapper.Map<FlowerReadDTO>(flower));
            else
                return NotFound();
        }


        [HttpPost]
        public ActionResult<FlowerCreateDTO> CreateFlower(FlowerCreateDTO flower)
        {
            var flowerModel = mapper.Map<Flower>(flower);
            flowerRepo.createFlower(flowerModel);
            flowerRepo.Save();

            var newFlower = mapper.Map<FlowerReadDTO>(flowerModel);
            return CreatedAtRoute(nameof(GetFlowerByID), new { flowerId = newFlower.flowerId }, newFlower);

        }
        [HttpDelete("{flowerId}")]

        public ActionResult Delete(int flowerId)
        {
            var flowerToDelete = flowerRepo.GetFlowerById(flowerId);
            if (flowerToDelete == null)
                return NotFound();
            flowerRepo.delete(flowerToDelete);
            return Ok();

        }
        [HttpPut]
        public ActionResult Update(int flowerId, FlowerCreateDTO flower)
        {
            var updateFlower = mapper.Map<Flower>(flower);
            updateFlower.flowerId = flowerId;
            if(!flowerRepo.update(updateFlower))
                return NotFound();
            else
                return Ok();

        }
        

    }
}
