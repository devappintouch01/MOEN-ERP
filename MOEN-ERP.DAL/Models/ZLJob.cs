using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class ZLJob
{
    public long JobId { get; set; }

    public long? FlowId { get; set; }

    public string? Version { get; set; }

    public long? OwnerId { get; set; }

    public string? ProcessCode { get; set; }

    public long? CurrentUserId { get; set; }

    public string? PreviuosProcessCode { get; set; }

    public long? PreviuosUserId { get; set; }

    public string? NextProcessCode { get; set; }

    public string? StatusId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? JsonData { get; set; }

    public string? ParameterString1 { get; set; }

    public string? ParameterString2 { get; set; }

    public string? ParameterString3 { get; set; }

    public int? ParameterInt1 { get; set; }

    public int? ParameterInt2 { get; set; }

    public int? ParameterInt3 { get; set; }

    public decimal? ParameterDecimal1 { get; set; }

    public decimal? ParameterDecimal2 { get; set; }

    public decimal? ParameterDecimal3 { get; set; }

    public bool? ParameterBit1 { get; set; }

    public bool? ParameterBit2 { get; set; }

    public bool? ParameterBit3 { get; set; }

    /// <summary>
    /// ข้อมูลJson Properties
    /// </summary>
    public string? JsonElementId { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }
}
