﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public abstract class Biciklo : Usluga
    {
        public string idBicikla { get; set; }



        public abstract float izracunajCijenu();
    }
}
