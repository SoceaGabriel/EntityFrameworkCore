﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class FluentBookDetail
    {
        public int FluentBookDetailId { get; set; }
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }
    }
}
