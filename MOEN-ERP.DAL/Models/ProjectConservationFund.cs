using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// งาน/โครงการกองทุนอนุรักษ์
/// </summary>
public partial class ProjectConservationFund
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
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
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// บทนำ
    /// </summary>
    public string? Preface { get; set; }

    /// <summary>
    /// ความเป็นมาของปัญหาที่เกิดขึ้นในปัจจุบัน
    /// </summary>
    public string? HistoryCurrent { get; set; }

    /// <summary>
    /// การดำเนินงานที่ผ่านมา
    /// </summary>
    public string? PastOperation { get; set; }

    /// <summary>
    /// ขั้นตอน/กระบวนการดำเนินงาน
    /// </summary>
    public string? OperationProcess { get; set; }

    /// <summary>
    /// ผลประโยชน์ที่คาดว่าจะได้รับจากการดำเนินโครงการ
    /// </summary>
    public string? Benefits { get; set; }

    /// <summary>
    /// ตัวชี้วัดเชิงปริมาณ
    /// </summary>
    public string? ProjectKpiquantity { get; set; }

    /// <summary>
    /// ตัวชี้วัดเชิงคุณภาพ
    /// </summary>
    public string? ProjectKpiquality { get; set; }

    /// <summary>
    /// แผน
    /// </summary>
    public string? WorkPlan { get; set; }

    /// <summary>
    /// กลุ่มงาน
    /// </summary>
    public string? WorkGroup { get; set; }
}
