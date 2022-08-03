using System;
namespace Intro_API.DTOs.Engine
{
    public class EngineGetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string HP { get; set; }

        public string Value { get; set; }

        public short Torque { get; set; }
    }
}

