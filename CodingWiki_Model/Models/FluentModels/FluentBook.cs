﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class FluentBook
    {
        public int FluentBookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }
    }
}
