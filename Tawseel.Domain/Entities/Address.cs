﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.Domain.Entities
{
    public class Address : NamedEntity
    {        
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }          
    }
}