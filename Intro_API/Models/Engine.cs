using System;
using System.Collections.Generic;
using Intro_API.Models.Base;

namespace Intro_API.Models
{
    public class Engine:BaseEntity
    {
        public string Name { get; set; }

        public string HP { get; set; }

        public string Value { get; set; }

        public short Torque { get; set; }

        public List<Car> Cars { get; set; }
    }
}

