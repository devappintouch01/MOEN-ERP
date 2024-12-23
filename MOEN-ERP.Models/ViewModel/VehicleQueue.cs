using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleQueueData
{
    public class SearchVehicleQueueView
    {
        public DateTime? SearchQueueDate { get; set; }
       // public DateTime? CurrentQueueDate { get; set; }
        public string? SearchAction { get; set; }
    }

    public class VehicleQueueDetailView
    {   
        public List<VVehicleQueue>? VehicleQueueList { get; set; }
        public DateTime? CurrentQueueDate { get; set; }

    }


    public class VehicleQueueManagement
    {
        public List<VehicleQueue>? VehicleQueueList { get; set; }
        public DateTime? CurrentQueueDate { get; set; }

    }

}
