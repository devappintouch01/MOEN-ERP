﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class SearchVehicleListForAssign
    {
        public DateTime? TravelFromDate { get; set; }
        public DateTime? TravelToDate { get; set; }
        public int? VehicleType { get; set; }
    }
}