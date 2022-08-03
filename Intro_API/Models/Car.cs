using System;
using Intro_API.Models.Base;

namespace Intro_API.Models
{
    public class Car:BaseEntity
    {

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public int? EngineId { get; set; }

        public Engine Engine { get; set; }
    }
}

