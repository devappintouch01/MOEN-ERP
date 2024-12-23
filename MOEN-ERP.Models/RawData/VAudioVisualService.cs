﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAudioVisualService
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        //public bool? IsParent { get; set; }

       // public int? ParentServiceId { get; set; }

        //public string? ParentServiceName { get; set; }

        public string? FormTypeName { get; set; }

        //public int? Sequence { get; set; }

        public bool? Active { get; set; }

       // public bool? IsDelete { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
