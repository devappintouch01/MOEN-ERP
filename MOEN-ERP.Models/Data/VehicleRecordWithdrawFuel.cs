using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleRecordWithdrawFuel
    {
        /// <summary>
        /// รหัสอ้างอิงการดำเนินการจองยานพาหนะที่ใช้ในระบบ
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ผู้สร้าง อ้างอิง SystemUser.Id
        /// </summary>
        public int? CreateBy { get; set; }

        /// <summary>
        /// วันที่สร้าง
        /// </summary>
        public DateTime? CreateOn { get; set; }

        /// <summary>
        /// ผู้แก้ไข อ้างอิง SystemUser.Id
        /// </summary>
        public int? UpdateBy { get; set; }

        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? UpdateOn { get; set; }

        /// <summary>
        /// รหัสผู้ดำเนินการ อ้างอิง Officer.Id
        /// </summary>
        public int? ActorId { get; set; }

        /// <summary>
        /// รหัสยานพาหนะ อ้างอิง Vehicle.Id
        /// </summary>
        public int? VehicleId { get; set; }

        /// <summary>
        /// รหัสประเภทน้ำมัน  อ้างอิง MasterFuelType.Id
        /// </summary>
        public int? FuelTypeId { get; set; }

        /// <summary>
        /// วันที่เบิกบัตร
        /// </summary>
        public DateTime? WithdrawDate { get; set; }

        /// <summary>
        /// วันที่คืนบัตร
        /// </summary>
        public DateTime? ReturnedDate { get; set; }

        /// <summary>
        /// เลขกิโลเมตร
        /// </summary>
        public decimal? Kilometer { get; set; }

        /// <summary>
        /// ราคาต่อหน่วย
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// รหัสหมายเลขบัตรน้ำมัน  อ้างอิง MasterFuelCode.Id
        /// </summary>
        public int? FuelCodeId { get; set; }

        /// <summary>
        /// เลขที่ใบบันทึกรายการ
        /// </summary>
        public int? ReceiptNo { get; set; }

        public string? Remark { get; set; }

        public double? FuelQuantity { get; set; }

        public double? FuelQuantityBalance { get; set; }
    }
}
