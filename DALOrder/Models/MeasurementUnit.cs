﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class MeasurementUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
