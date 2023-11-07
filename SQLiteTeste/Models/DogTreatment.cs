﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTeste.Models
{
    public class WaterControl
    {
        public int Id { get; set; }
        
        public int Water { get; set; }
        public int WaterDrank { get; set; }
        public DateTime Date { get; set; }
    }
}
