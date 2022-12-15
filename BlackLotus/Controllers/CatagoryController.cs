using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlackLotus.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class CatagoryController : Controller
    {
        private readonly ICatagoryRepo catagoryRepo;
        private readonly IMapper mapper;

        public CatagoryController(ICatagoryRepo _catagoryRepo, IMapper _mapper)

        {
            catagoryRepo = _catagoryRepo;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CatagoryReadDTO>> GetCatagory()
        {
            var catagory = catagoryRepo.GetCatagory();
            return Ok(mapper.Map<IEnumerable<CatagoryReadDTO>>(catagory));
        }
        [HttpGet("{catagoryId}", Name = "GetCatagoryById")]
        public ActionResult<CatagoryReadDTO> GetCatagoryById(int catagoryId)
        {
            var catagory = catagoryRepo.GetCatagoryById(catagoryId);
            if (catagory != null)
                return Ok(mapper.Map<CatagoryReadDTO>(catagory));
            else
                return NotFound();
        }


        [HttpPost]
        public ActionResult<CatagoryCreateDTO> CreateCatagory(CatagoryCreateDTO catagory)
        {
            var catagoryModel = mapper.Map<Catagory>(catagory);
            catagoryRepo.createCatagory(catagoryModel);
            catagoryRepo.Save();

            var newCatagory = mapper.Map<CatagoryReadDTO>(catagoryModel);
            return CreatedAtRoute(nameof(GetCatagoryById), new { catagoryId = newCatagory.catagoryId }, newCatagory);

        }
        [HttpDelete("{catagoryId}")]

        public ActionResult Delete(int catagoryId)
        {
            var catagoryToDelete = catagoryRepo.GetCatagoryById(catagoryId);
            if (catagoryToDelete == null)
                return NotFound();
            catagoryRepo.delete(catagoryToDelete);
            return Ok();

        }
        [HttpPut]
        public ActionResult Update(int catagoryId, CatagoryCreateDTO catagory)
        {
            var updateCatagory = mapper.Map<Catagory>(catagory);
            updateCatagory.catagoryId = catagoryId;
            if (!catagoryRepo.update(updateCatagory))
                return NotFound();
            else
                return Ok();

        }
    }
}
