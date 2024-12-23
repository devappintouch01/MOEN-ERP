using Microsoft.AspNetCore.Mvc.Rendering;
using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class SupplierModel
    {
        public Supplier Supplier { get; set; }

        public List<SelectListItem>? listItemProvince { get; set; }
        public List<SelectListItem>? listItemMasterAmphur { get; set; }
        public List<SelectListItem>? listItemMasterTambon { get; set; }      
        public Boolean blnSetCMBAmphur { get; set; }
        public Boolean blnSetCMBTambon { get; set; }
        public int? setProvinceId { get; set; }
        public int? setAmphurId { get; set; }
        public int? setTambonId { get; set; }
        public string? setZipCode { get; set; }

        public List<string>? FileGuidId { get; set; }


    }
}
