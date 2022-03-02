using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsControler : ControllerBase
    {
        ICarService _carservice;
        private readonly IMapper _mapper;

        public CarsControler(ICarService carservice, IMapper mapper)
        {
            _carservice = carservice;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //dependency chain--
            //swagger :dökümantasyon 
            var result = _carservice.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")] 
        public IActionResult GetById(int id)
        {
            var result = _carservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CarDto  carDto)
        {
            //var car = _service.AddAsync(_mapper.Map<Product>(proDto));
            var result = _carservice.Add(_mapper.Map<Car>(carDto));


            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
