using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VehicleDriverDetail
    {
        public VOfficer? VOfficer { get; set; }
        public AttachFile? AttachFile { get; set; }
    }
}
