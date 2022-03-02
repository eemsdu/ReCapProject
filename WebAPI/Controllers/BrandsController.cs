using AutoMapper;
using Business.Abstract;
using Business.Constans;
using Core2.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly IMapper  _mapper;

        public BrandsController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById( int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        
        [HttpPost("Add")]
        public IActionResult Add(BrandDto brandDto )
        {

            var result = _brandService.Add(_mapper.Map<Brand>(brandDto));
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
                 var res = _brandService.GetById(id);
                _brandService.Delete(res.Data);
                  
                return Ok();         
        }
    }
}
