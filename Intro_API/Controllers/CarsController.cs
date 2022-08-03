using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intro_API.DAL;
using Intro_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly APIDbContext _context;

        public CarsController(APIDbContext context)
        {
            this._context = context;
        }
        private List<Car> _cars = new List<Car>()
        {
            new Car
            {
                Brand="Mercedes",
                Model="S-500",
                Price=130000,
                Color="White"
            },
            new Car
            {
                Brand="BMW",
                Model="F-90",
                Price=170000,
                Color="Red"
            },
            new Car
            {
                Brand="Lamborghini",
                Model="Urus",
                Price=300000,
                Color="Yellow"
            },
        };
        

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            Car car = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (car is null) return StatusCode(StatusCodes.Status404NotFound);
            return Ok(car);

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Car> cars=_context.Cars.ToList();
            return Ok(cars);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Car car)
        {
            if (car is null) return NotFound();
            _context.Cars.Add(car);
            _context.SaveChanges();
            return StatusCode(201, car);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id,Car car)
        {
            if (id == 0) return BadRequest();

            Car existed = _context.Cars.FirstOrDefault(c=>c.Id==id);
            if (existed is null) return NotFound();
            existed.Brand = car.Brand;
            existed.Model = car.Model;
            existed.Price = car.Price;
            existed.Color = car.Color;
            _context.SaveChanges();
            return NoContent();
               
        }
        [HttpDelete("delete/{id}")]
        
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            Car existed = _context.Cars.FirstOrDefault(c=>c.Id==id);
            if (existed is null) return NotFound();

            _context.Cars.Remove(existed);
            _context.SaveChanges();
            return NoContent();
        }
    }
}