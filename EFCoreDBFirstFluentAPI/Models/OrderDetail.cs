﻿using System;
using System.Collections.Generic;

namespace EFCoreDBFirstFluentAPI.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; } = null!;
    }
}
