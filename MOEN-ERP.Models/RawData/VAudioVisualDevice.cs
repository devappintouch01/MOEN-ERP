﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAudioVisualDevice
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public int? TotalAll { get; set; }

        public int? TotalRemain { get; set; }

        public bool? Active { get; set; }      

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}