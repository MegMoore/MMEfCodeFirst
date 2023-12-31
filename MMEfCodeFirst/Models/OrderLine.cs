﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MMEfCodeFirst.Models
{
   public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order? Order { get; set; }

        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }

    }
}
