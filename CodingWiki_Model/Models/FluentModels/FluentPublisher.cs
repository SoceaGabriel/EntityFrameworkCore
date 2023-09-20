﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class FluentPublisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
