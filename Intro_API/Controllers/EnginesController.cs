using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intro_API.DAL;
using Intro_API.DTOs;
using Intro_API.DTOs.Engine;
using Intro_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnginesController : ControllerBase
    {
        private readonly APIDbContext context;

        public EnginesController(APIDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            Engine engine = context.Engines.FirstOrDefault(e => e.Id == id);
            if (engine is null) return NotFound();
            EngineGetDto dto = new EngineGetDto
            {
                Id = engine.Id,
                HP =engine.HP,
                Name=engine.Name,
                Torque=engine.Torque,
                Value=engine.Value
            };
            return Ok(dto);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create( EnginePostDto dto)
        {
            if (dto is null) return BadRequest();
            Engine engine = new Engine
            {
                Name = dto.Name,
                HP = dto.HP,
                Value = dto.Value,
                Torque = dto.Torque,
            };
            context.Engines.Add(engine);
            await context.SaveChangesAsync();
            return Created("hello", dto);
            //return StatusCode(201, dto);
        }
    }
}