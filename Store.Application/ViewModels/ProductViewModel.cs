﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
