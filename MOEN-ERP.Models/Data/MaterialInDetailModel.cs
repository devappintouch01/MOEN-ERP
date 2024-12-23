using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class MaterialInDetailModel
    {
        public MaterialIn materialIn {  get; set; }
        public List<VMaterialInItem>? lstVMaterialInItems { get; set; }
        public string? guidPage { get; set; }

    }
}
