using AutoMapper;
using dotnet_api_test.Models.Dtos;
using dotnet_api_test.Persistence.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_api_test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly ILogger<DishController> _logger;
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;

        public DishController(ILogger<DishController> logger, IMapper mapper, IDishRepository dishRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _dishRepository = dishRepository;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<DishesAndAveragePriceDto> GetDishesAndAverageDishPrice()
        {
            var dishes = _dishRepository.GetAllDishes();
            List<ReadDishDto> readDishDtoList = new List<ReadDishDto>();
            foreach (var dish in dishes)
            {
                readDishDtoList.Add(_mapper.Map<ReadDishDto>(dish));
            }            
            var average = _dishRepository.GetAverageDishPrice();
            DishesAndAveragePriceDto avg = new DishesAndAveragePriceDto { Dishes = readDishDtoList, AveragePrice = average };
            return Ok(avg);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadDishDto> GetDishById(int id)
        {
            if (_dishRepository.GetDishById(id) != null)
            {
                return Ok(_dishRepository.GetDishById(id));                
            }
            return NotFound();
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ReadDishDto> CreateDish([FromBody] CreateDishDto createDishDto)
        {
            var created = _mapper.Map<Dish>(createDishDto);
            return Ok(_dishRepository.CreateDish(created));
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ReadDishDto> UpdateDishById(int id, UpdateDishDto updateDishDto)
        {
            Dish update = _dishRepository.GetDishById(id);

            if (update != null)
            {
                if (updateDishDto.Name != "string")
                {
                    update.Name = updateDishDto.Name;
                }

                if (updateDishDto.MadeBy != "string")
                {
                    update.MadeBy = updateDishDto.MadeBy;
                }

                if (updateDishDto.Cost != 0 && updateDishDto.Cost < update.Cost * 1.2)
                {
                    update.Cost = Convert.ToDouble(updateDishDto.Cost);
                }
                return Ok(_dishRepository.UpdateDish(update));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteDishById(int id)
        {
            _dishRepository.DeleteDishById(id);
            return Ok();
        }
    }
}