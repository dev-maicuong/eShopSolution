﻿using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParenId { get; set; }
        public Status Status { get; set; }
    }
}
