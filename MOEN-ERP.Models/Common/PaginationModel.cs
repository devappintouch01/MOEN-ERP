using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
    public class PaginationModel
    {
        /// <summary>
        /// หน้าที่แสดงปัจบัน
        /// </summary>
        public int? Page { get; set; }   
        ///// <summary>
        ///// หน้าทั้งหมด
        ///// </summary>
        public int? TotalPage { get; set; }
        /// <summary>
        /// รายการทั้งหมด
        /// </summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// แสดงกี่รายการต่อหน้า
        /// </summary>
        public int? Show { get; set; }

        public int? Start { get; set;}
        public int? End { get; set; }
    }

}
