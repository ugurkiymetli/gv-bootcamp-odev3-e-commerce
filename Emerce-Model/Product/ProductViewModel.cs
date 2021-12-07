﻿using System;

namespace Emerce_Model.Product
{
    public class ProductViewModel
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime Idatetime { get; set; }
        public DateTime Udatetime { get; set; }
        public string Iuser { get; set; }
    }
}