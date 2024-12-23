using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.DAL.Models;

public partial class MOENDBContext : DbContext
{
    public MOENDBContext()
    {
    }

    public MOENDBContext(DbContextOptions<MOENDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnnualCheck> AnnualChecks { get; set; }

    public virtual DbSet<AnnualCheckAsset> AnnualCheckAssets { get; set; }

    public virtual DbSet<AnnualCheckCommittee> AnnualCheckCommittees { get; set; }

    public virtual DbSet<AnnualCheckMaterial> AnnualCheckMaterials { get; set; }

    public virtual DbSet<AnnualCheckOrganization> AnnualCheckOrganizations { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetBorrow> AssetBorrows { get; set; }

    public virtual DbSet<AssetBorrowItem> AssetBorrowItems { get; set; }

    public virtual DbSet<AssetChange> AssetChanges { get; set; }

    public virtual DbSet<AssetDepreciation> AssetDepreciations { get; set; }

    public virtual DbSet<AssetMaintenance> AssetMaintenances { get; set; }

    public virtual DbSet<AssetMaintenanceForm> AssetMaintenanceForms { get; set; }

    public virtual DbSet<AssetMaintenanceFormItem> AssetMaintenanceFormItems { get; set; }

    public virtual DbSet<AssetMaintenanceFormItemList> AssetMaintenanceFormItemLists { get; set; }

    public virtual DbSet<AssetRelation> AssetRelations { get; set; }

    public virtual DbSet<AssetRequisition> AssetRequisitions { get; set; }

    public virtual DbSet<AssetRequisitionItem> AssetRequisitionItems { get; set; }

    public virtual DbSet<AssetReturn> AssetReturns { get; set; }

    public virtual DbSet<AssetReturnItem> AssetReturnItems { get; set; }

    public virtual DbSet<AssetTransfer> AssetTransfers { get; set; }

    public virtual DbSet<AssetTransferItem> AssetTransferItems { get; set; }

    public virtual DbSet<AssetWriteOff> AssetWriteOffs { get; set; }

    public virtual DbSet<AssetWriteOffItem> AssetWriteOffItems { get; set; }

    public virtual DbSet<BudgetDisbursementPlan> BudgetDisbursementPlans { get; set; }

    public virtual DbSet<BudgetDisbursementPlanItem> BudgetDisbursementPlanItems { get; set; }

    public virtual DbSet<BudgetGovernment> BudgetGovernments { get; set; }

    public virtual DbSet<BudgetGovernmentItem> BudgetGovernmentItems { get; set; }

    public virtual DbSet<BudgetReceive> BudgetReceives { get; set; }

    public virtual DbSet<BudgetRequest> BudgetRequests { get; set; }

    public virtual DbSet<MasterActivityCode> MasterActivityCodes { get; set; }

    public virtual DbSet<MasterActivityLogType> MasterActivityLogTypes { get; set; }

    public virtual DbSet<MasterAmphur> MasterAmphurs { get; set; }

    public virtual DbSet<MasterAssetAcquisitionType> MasterAssetAcquisitionTypes { get; set; }

    public virtual DbSet<MasterAssetBudgetType> MasterAssetBudgetTypes { get; set; }

    public virtual DbSet<MasterAssetClass> MasterAssetClasses { get; set; }

    public virtual DbSet<MasterAssetType> MasterAssetTypes { get; set; }

    public virtual DbSet<MasterAssetTypeSub> MasterAssetTypeSubs { get; set; }

    public virtual DbSet<MasterBank> MasterBanks { get; set; }

    public virtual DbSet<MasterBudgetExpenseType> MasterBudgetExpenseTypes { get; set; }

    public virtual DbSet<MasterBudgetFormType> MasterBudgetFormTypes { get; set; }

    public virtual DbSet<MasterBudgetType> MasterBudgetTypes { get; set; }

    public virtual DbSet<MasterConsistency> MasterConsistencies { get; set; }

    public virtual DbSet<MasterCostCenter> MasterCostCenters { get; set; }

    public virtual DbSet<MasterDocumentType> MasterDocumentTypes { get; set; }

    public virtual DbSet<MasterExpenseType> MasterExpenseTypes { get; set; }

    public virtual DbSet<MasterFuelType> MasterFuelTypes { get; set; }

    public virtual DbSet<MasterFund> MasterFunds { get; set; }

    public virtual DbSet<MasterLandType> MasterLandTypes { get; set; }

    public virtual DbSet<MasterMaterial> MasterMaterials { get; set; }

    public virtual DbSet<MasterMaterialGpsc> MasterMaterialGpscs { get; set; }

    public virtual DbSet<MasterMaterialGroup> MasterMaterialGroups { get; set; }

    public virtual DbSet<MasterMoneySource> MasterMoneySources { get; set; }

    public virtual DbSet<MasterNamePrefix> MasterNamePrefixes { get; set; }

    public virtual DbSet<MasterOrganization> MasterOrganizations { get; set; }

    public virtual DbSet<MasterOutputCode> MasterOutputCodes { get; set; }

    public virtual DbSet<MasterPosition> MasterPositions { get; set; }

    public virtual DbSet<MasterProcurementMethod> MasterProcurementMethods { get; set; }

    public virtual DbSet<MasterProcurementMethodStep> MasterProcurementMethodSteps { get; set; }

    public virtual DbSet<MasterProvince> MasterProvinces { get; set; }

    public virtual DbSet<MasterReturnReason> MasterReturnReasons { get; set; }

    public virtual DbSet<MasterStandardPrice> MasterStandardPrices { get; set; }

    public virtual DbSet<MasterStatus> MasterStatuses { get; set; }

    public virtual DbSet<MasterStorePlace> MasterStorePlaces { get; set; }

    public virtual DbSet<MasterStrategicPlanCode> MasterStrategicPlanCodes { get; set; }

    public virtual DbSet<MasterStrategyCode> MasterStrategyCodes { get; set; }

    public virtual DbSet<MasterSystemName> MasterSystemNames { get; set; }

    public virtual DbSet<MasterTambon> MasterTambons { get; set; }

    public virtual DbSet<MasterUnit> MasterUnits { get; set; }

    public virtual DbSet<MasterWarehouse> MasterWarehouses { get; set; }

    public virtual DbSet<MasterWriteOffType> MasterWriteOffTypes { get; set; }

    public virtual DbSet<MaterialBorrow> MaterialBorrows { get; set; }

    public virtual DbSet<MaterialBorrowItem> MaterialBorrowItems { get; set; }

    public virtual DbSet<MaterialIn> MaterialIns { get; set; }

    public virtual DbSet<MaterialInItem> MaterialInItems { get; set; }

    public virtual DbSet<MaterialRequisition> MaterialRequisitions { get; set; }

    public virtual DbSet<MaterialRequisitionItem> MaterialRequisitionItems { get; set; }

    public virtual DbSet<MaterialSafetyStock> MaterialSafetyStocks { get; set; }

    public virtual DbSet<MaterialStock> MaterialStocks { get; set; }

    public virtual DbSet<MaterialStockMovement> MaterialStockMovements { get; set; }

    public virtual DbSet<Officer> Officers { get; set; }

    public virtual DbSet<Procurement> Procurements { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectActivityPlanItem> ProjectActivityPlanItems { get; set; }

    public virtual DbSet<ProjectActivityPlanItemPeriod> ProjectActivityPlanItemPeriods { get; set; }

    public virtual DbSet<ProjectAsset> ProjectAssets { get; set; }

    public virtual DbSet<ProjectAssetItem> ProjectAssetItems { get; set; }

    public virtual DbSet<ProjectConcessionFund> ProjectConcessionFunds { get; set; }

    public virtual DbSet<ProjectConservationFund> ProjectConservationFunds { get; set; }

    public virtual DbSet<ProjectExpensesItem> ProjectExpensesItems { get; set; }

    public virtual DbSet<ProjectProcurementPlanItem> ProjectProcurementPlanItems { get; set; }

    public virtual DbSet<ProjectProgressPlanItem> ProjectProgressPlanItems { get; set; }

    public virtual DbSet<ProjectProvince> ProjectProvinces { get; set; }

    public virtual DbSet<ProjectSupplier> ProjectSuppliers { get; set; }

    public virtual DbSet<ProjectSupplierItem> ProjectSupplierItems { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SystemConfig> SystemConfigs { get; set; }

    public virtual DbSet<SystemMenu> SystemMenus { get; set; }

    public virtual DbSet<SystemMenuGroup> SystemMenuGroups { get; set; }

    public virtual DbSet<SystemMenuRoleAssign> SystemMenuRoleAssigns { get; set; }

    public virtual DbSet<SystemNotification> SystemNotifications { get; set; }

    public virtual DbSet<SystemRole> SystemRoles { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    public virtual DbSet<SystemUserRoleAssign> SystemUserRoleAssigns { get; set; }

    public virtual DbSet<VAnnualCheck> VAnnualChecks { get; set; }

    public virtual DbSet<VAnnualCheckAsset> VAnnualCheckAssets { get; set; }

    public virtual DbSet<VAnnualCheckAssetReport> VAnnualCheckAssetReports { get; set; }

    public virtual DbSet<VAnnualCheckCommittee> VAnnualCheckCommittees { get; set; }

    public virtual DbSet<VAnnualCheckMaterial> VAnnualCheckMaterials { get; set; }

    public virtual DbSet<VAnnualCheckOrganization> VAnnualCheckOrganizations { get; set; }

    public virtual DbSet<VAnnualCheckOrganizationReport> VAnnualCheckOrganizationReports { get; set; }

    public virtual DbSet<VAsset> VAssets { get; set; }

    public virtual DbSet<VAssetBorrow> VAssetBorrows { get; set; }

    public virtual DbSet<VAssetBorrowItem> VAssetBorrowItems { get; set; }

    public virtual DbSet<VAssetBorrowReport> VAssetBorrowReports { get; set; }

    public virtual DbSet<VAssetChange> VAssetChanges { get; set; }

    public virtual DbSet<VAssetMaintenance> VAssetMaintenances { get; set; }

    public virtual DbSet<VAssetMaintenanceForm> VAssetMaintenanceForms { get; set; }

    public virtual DbSet<VAssetMaintenanceFormItem> VAssetMaintenanceFormItems { get; set; }

    public virtual DbSet<VAssetRelation> VAssetRelations { get; set; }

    public virtual DbSet<VAssetRequisition> VAssetRequisitions { get; set; }

    public virtual DbSet<VAssetRequisitionItem> VAssetRequisitionItems { get; set; }

    public virtual DbSet<VAssetReturn> VAssetReturns { get; set; }

    public virtual DbSet<VAssetReturnItem> VAssetReturnItems { get; set; }

    public virtual DbSet<VAssetTransfer> VAssetTransfers { get; set; }

    public virtual DbSet<VAssetTransferItem> VAssetTransferItems { get; set; }

    public virtual DbSet<VAssetTransferReport> VAssetTransferReports { get; set; }

    public virtual DbSet<VAssetWaitingSale> VAssetWaitingSales { get; set; }

    public virtual DbSet<VAssetWriteOff> VAssetWriteOffs { get; set; }

    public virtual DbSet<VAssetWriteOffItem> VAssetWriteOffItems { get; set; }

    public virtual DbSet<VAssetWriteOffReport> VAssetWriteOffReports { get; set; }

    public virtual DbSet<VBudgetAllocateList> VBudgetAllocateLists { get; set; }

    public virtual DbSet<VBudgetDisbursementPlan> VBudgetDisbursementPlans { get; set; }

    public virtual DbSet<VBudgetDisbursementPlanItem> VBudgetDisbursementPlanItems { get; set; }

    public virtual DbSet<VBudgetDisbursementPlanItemPivot> VBudgetDisbursementPlanItemPivots { get; set; }

    public virtual DbSet<VBudgetGovernment> VBudgetGovernments { get; set; }

    public virtual DbSet<VBudgetGovernmentItem> VBudgetGovernmentItems { get; set; }

    public virtual DbSet<VBudgetReceive> VBudgetReceives { get; set; }

    public virtual DbSet<VBudgetRequest> VBudgetRequests { get; set; }

    public virtual DbSet<VMasterActivityCode> VMasterActivityCodes { get; set; }

    public virtual DbSet<VMasterAssetClass> VMasterAssetClasses { get; set; }

    public virtual DbSet<VMasterAssetType> VMasterAssetTypes { get; set; }

    public virtual DbSet<VMasterBudgetExpenseType> VMasterBudgetExpenseTypes { get; set; }

    public virtual DbSet<VMasterMaterial> VMasterMaterials { get; set; }

    public virtual DbSet<VMasterMaterialGroup> VMasterMaterialGroups { get; set; }

    public virtual DbSet<VMasterOutputCode> VMasterOutputCodes { get; set; }

    public virtual DbSet<VMasterStandardPrice> VMasterStandardPrices { get; set; }

    public virtual DbSet<VMasterStorePlace> VMasterStorePlaces { get; set; }

    public virtual DbSet<VMasterStrategicPlanCode> VMasterStrategicPlanCodes { get; set; }

    public virtual DbSet<VMasterStrategyCode> VMasterStrategyCodes { get; set; }

    public virtual DbSet<VMasterUnit> VMasterUnits { get; set; }

    public virtual DbSet<VMasterWarehouse> VMasterWarehouses { get; set; }

    public virtual DbSet<VMaterialBorrow> VMaterialBorrows { get; set; }

    public virtual DbSet<VMaterialBorrowItem> VMaterialBorrowItems { get; set; }

    public virtual DbSet<VMaterialIn> VMaterialIns { get; set; }

    public virtual DbSet<VMaterialInItem> VMaterialInItems { get; set; }

    public virtual DbSet<VMaterialRequisition> VMaterialRequisitions { get; set; }

    public virtual DbSet<VMaterialRequisitionItem> VMaterialRequisitionItems { get; set; }

    public virtual DbSet<VMaterialSafetyStock> VMaterialSafetyStocks { get; set; }

    public virtual DbSet<VMaterialStock> VMaterialStocks { get; set; }

    public virtual DbSet<VMonthList> VMonthLists { get; set; }

    public virtual DbSet<VOfficer> VOfficers { get; set; }

    public virtual DbSet<VProcurement> VProcurements { get; set; }

    public virtual DbSet<VProject> VProjects { get; set; }

    public virtual DbSet<VProjectActivityPlanItem> VProjectActivityPlanItems { get; set; }

    public virtual DbSet<VProjectActivityPlanItemPeriod> VProjectActivityPlanItemPeriods { get; set; }

    public virtual DbSet<VProjectAsset> VProjectAssets { get; set; }

    public virtual DbSet<VProjectAssetItem> VProjectAssetItems { get; set; }

    public virtual DbSet<VProjectExpensesItem> VProjectExpensesItems { get; set; }

    public virtual DbSet<VProjectProcurementPlanItem> VProjectProcurementPlanItems { get; set; }

    public virtual DbSet<VProjectProgressPlanItem> VProjectProgressPlanItems { get; set; }

    public virtual DbSet<VProjectProvince> VProjectProvinces { get; set; }

    public virtual DbSet<VProjectSupplier> VProjectSuppliers { get; set; }

    public virtual DbSet<VProjectSupplierItem> VProjectSupplierItems { get; set; }

    public virtual DbSet<VSupplier> VSuppliers { get; set; }

    public virtual DbSet<VSystemUser> VSystemUsers { get; set; }

    public virtual DbSet<VSystemUserRoleAssign> VSystemUserRoleAssigns { get; set; }

    public virtual DbSet<ZLFlow> ZLFlows { get; set; }

    public virtual DbSet<ZLJob> ZLJobs { get; set; }

    public virtual DbSet<ZLJobLog> ZLJobLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dev.softsuite.co.th;Database=MOENDB;User Id=energyerpadmin;Password=!energy2024!;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnnualCheck>(entity =>
        {
            entity.ToTable("AnnualCheck", tb => tb.HasComment("การตรวจสอบประจำปี"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AnnualCheckFromDate)
                .HasComment("วันที่เริ่มต้น")
                .HasColumnType("datetime");
            entity.Property(e => e.AnnualCheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการตรวจสอบประจำปี (A=อยู่ระหว่างดำเนินการ, C=รับรองผล)");
            entity.Property(e => e.AnnualCheckToDate)
                .HasComment("วันที่สิ้นสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่รับรองผล")
                .HasColumnType("datetime");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสพื้นที่");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่อ้างอิง");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsApprove).HasComment("การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)");
            entity.Property(e => e.IsCreate)
                .HasDefaultValueSql("((0))")
                .HasComment("การสร้างรายการตรวจนับ (True=สร้างแล้ว, False=ยังไม่สร้าง)");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnualCheckAsset>(entity =>
        {
            entity.ToTable("AnnualCheckAsset", tb => tb.HasComment("ครุภัณฑ์ที่ตรวจสอบประจำปี"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AnnualCheckOrganizationId).HasComment("การตรวจสอบประจำปีของแต่ละหน่วยงาน อ้างอิง AnnualCheckOrganization.Id");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasComment("สถานะการตรวจสอบ (Y=พบ, N=ไม่พบ, W=พบผิดที่)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsChangeStorePlace)
                .HasDefaultValueSql("((0))")
                .HasComment("เปลี่ยนสถานที่จัดเก็บ/ใช้งาน (True=เปลี่ยน, N=ไม่เปลี่ยน)");
            entity.Property(e => e.IsCheck)
                .HasDefaultValueSql("((0))")
                .HasComment("การตรวจสอบ (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)");
            entity.Property(e => e.IsReturn).HasComment("สถานะการส่งคืน (True=ส่งคืน, N=ไม่ส่งคืน)");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)");
            entity.Property(e => e.NewOrganizationId).HasComment("หน่วยงานใหม่ อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.NewStorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รายละเอียดสถานที่จัดเก็บ/ใช้งานใหม่");
            entity.Property(e => e.NewStorePlaceId).HasComment("สถานที่จัดเก็บ/ใช้งานใหม่ อ้างอิงตาราง MasterStorePlace.Id");
            entity.Property(e => e.OldOrganizationId).HasComment("หน่วยงานเดิม อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.OldStorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รายละเอียดสถานที่จัดเก็บ/ใช้งานเดิม");
            entity.Property(e => e.OldStorePlaceId).HasComment("สถานที่จัดเก็บ/ใช้งานเดิม อ้างอิงตาราง MasterStorePlace.Id");
            entity.Property(e => e.ReturnReasonId).HasComment("เหตุผลที่ส่งคืน อ้างอิง MasterReturnReason.Id");
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnualCheckCommittee>(entity =>
        {
            entity.ToTable("AnnualCheckCommittee", tb => tb.HasComment("คณะกรรมการตรวจสอบประจำปี"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AnnualCheckId).HasComment("การตรวจสอบประจำปี อ้างอิง AnnualCheck.Id");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่รับรองผล")
                .HasColumnType("datetime");
            entity.Property(e => e.CommitteePosition)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ตำแหน่งในชุดคณะกรรมการ (C=คณะกรรมการตรวจสอบประจำปี, P=ประธานคณะกรรมการตรวจสอบประจำปี)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsApprove).HasComment("การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)");
            entity.Property(e => e.OfficerId).HasComment("เจ้าหน้าที่ อ้างอิง Officer.Id ");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงานในการตรวจสอบประจำปี อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AnnualCheckMaterial>(entity =>
        {
            entity.ToTable("AnnualCheckMaterial", tb => tb.HasComment("วัสดุที่ตรวจสอบประจำปี"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AnnualCheckOrganizationId).HasComment("การตรวจสอบประจำปีของหน่วยงาน อ้างอิง AnnualCheckOrganization.Id");
            entity.Property(e => e.Available).HasComment("จำนวนหน่วย");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasComment("สถานะการตรวจสอบ (Y=ครบ, N=ไม่ครบ)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsCheck)
                .HasDefaultValueSql("((0))")
                .HasComment("การตรวจสอบ (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)");
            entity.Property(e => e.MaterialId).HasComment("รหัสวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("คำชี้แจง");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasComment("คลังที่เก็บวัสดุ อ้างอิง MasterWarehouse.Id");
        });

        modelBuilder.Entity<AnnualCheckOrganization>(entity =>
        {
            entity.ToTable("AnnualCheckOrganization", tb => tb.HasComment("การตรวจสอบประจำปีของหน่วยงาน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AnnualCheckFromDate)
                .HasComment("วันที่เริ่มต้น")
                .HasColumnType("datetime");
            entity.Property(e => e.AnnualCheckId).HasComment("การตรวจสอบประจำปี อ้างอิง AnnualCheck.Id");
            entity.Property(e => e.AnnualCheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการตรวจสอบประจำปี (A=อยู่ระหว่างดำเนินการ, C=รับรองผล)");
            entity.Property(e => e.AnnualCheckToDate)
                .HasComment("วันที่สิ้นสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่รับรองผล")
                .HasColumnType("datetime");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่อ้างอิง");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsApprove)
                .HasDefaultValueSql("((0))")
                .HasComment("การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงานในการตรวจสอบประจำปี อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.TotalBuilding).HasComment("จำนวนสิ่งปลูกสร้างทั้งหมด");
            entity.Property(e => e.TotalDurable).HasComment("จำนวนครุภัณฑ์ทั้งหมด");
            entity.Property(e => e.TotalNotFoundDurable).HasComment("จำนวนครุภัณฑ์ที่ไม่พบ");
            entity.Property(e => e.TotalReturnDurable).HasComment("จำนวนครุภัณฑ์ที่ส่งคืน");
            entity.Property(e => e.TotalUnusableBuilding).HasComment("จำนวนสิ่งปลูกสร้างที่ชำรุด");
            entity.Property(e => e.TotalUnusableDurable).HasComment("จำนวนครุภัณฑ์ที่ชำรุด");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.ToTable("Asset", tb => tb.HasComment("สินทรัพย์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่ตรวจรับ")
                .HasColumnType("datetime");
            entity.Property(e => e.AssetAcquisitionTypeId).HasComment("การได้มาของสินทรัพย์ อ้างอิง MasterAssetAcquisitionType.Id");
            entity.Property(e => e.AssetBudgetTypeId).HasComment("แหล่งเงิน อ้างอิง MasterAssetBudgetType.Id");
            entity.Property(e => e.AssetCategory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("กลุ่มสินทรัพย์ (B=อาคารและสิ่งปลูกสร้าง, C=รถยนต์, D=ครุภัณฑ์, I=สินทรัพย์ไม่มีตัวตน)");
            entity.Property(e => e.AssetClassId).HasComment("หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id");
            entity.Property(e => e.AssetDetail)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อรายการ");
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขสินทรัพย์")
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.AssetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน (A=ใช้งาน, C=ตัดจำหน่าย, W=รอจำหน่าย)");
            entity.Property(e => e.AssetTypeId).HasComment("หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ยี่ห้อ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่ออาคาร");
            entity.Property(e => e.CarSeats).HasComment("จำนวนที่นั่ง");
            entity.Property(e => e.ChassisNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขตัวรถ");
            entity.Property(e => e.Child).HasComment("จำนวนครุภัณฑ์ย่อย");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขครุภัณฑ์");
            entity.Property(e => e.CodeOld)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขครุภัณฑ์ (เดิม)");
            entity.Property(e => e.Cost)
                .HasComment("ราคาต่อหน่วย (บาท)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CostCenterId).HasComment("ศูนย์ต้นทุน อ้างอิง MasterCostCenter.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentBorrowerOfficerId).HasComment("ผู้ยืมคนปัจจุบัน อ้างอิง Officer.Id");
            entity.Property(e => e.CurrentResponsibleOfficerId).HasComment("ผู้เบิกคนปัจจุบัน อ้างอิง Officer.Id");
            entity.Property(e => e.Depreciation)
                .HasComment("อัตราค่าเสื่อม (ร้อยละ)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.DocumentDate)
                .HasComment("ลงวันที่เอกสาร")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.DocumentTypeId).HasComment("ประเภทเอกสาร อ้างอิง MasterDocumentType.Id");
            entity.Property(e => e.EngineNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขเครื่องยนต์");
            entity.Property(e => e.FuelTypeId).HasComment("รหัสประเภทเชื้อเพลิง อ้างอิง MasterFuelType.Id");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("IP Address")
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsBelow).HasComment("เป็นครุภัณฑ์ต่ำกว่าเกณฑ์ (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.IsChild)
                .HasDefaultValueSql("((0))")
                .HasComment("เป็นครุภัณฑ์ย่อย (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.IsInMa)
                .HasDefaultValueSql("((0))")
                .HasComment("อยู่ในช่วง MA (True=ใช่, False=ไม่ใช่)")
                .HasColumnName("IsInMA");
            entity.Property(e => e.IsSet)
                .HasDefaultValueSql("((0))")
                .HasComment("เป็นชุดครุภัณฑ์  (True=ชุด, False=เดี่ยว)");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ใช้งานได้, N=ใช้งานไม่ได้/ชำรุด)");
            entity.Property(e => e.LandTypeId).HasComment("ประเภทที่ดิน อ้างอิง MasterLandType.Id");
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขทะเบียนรถ");
            entity.Property(e => e.LifeTimeDepreciation).HasComment("อายุการใช้งาน(ใช้ในการคำนวณค่าเสื่อม) (ปี)");
            entity.Property(e => e.LifeTimeUse).HasComment("อายุการใช้งาน (ทดแทน) (ปี)");
            entity.Property(e => e.MainAssetId).HasComment("ครุภัณฑ์หลัก อ้างอิง Asset.Id");
            entity.Property(e => e.Model)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รุ่น/แบบ");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.ProcurementAssetItemId).HasComment("ครุภัณฑ์ที่จัดซื้อ/จัดจ้าง อ้างอิง ProcurementAssetItem.Id");
            entity.Property(e => e.ProcurementCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.ProcurementEndDate)
                .HasComment("วันที่สิ้นสุดสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.ProcurementId).HasComment("โครงการจัดซื้อ/จัดจ้าง อ้างอิง Procurement.Id");
            entity.Property(e => e.ProcurementMethodId).HasComment("วิธีการได้มา อ้างอิง MasterProcurementMethod.Id");
            entity.Property(e => e.ProcurementStartDate)
                .HasComment("วันที่เริ่มต้นสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ผู้ให้บริการ (Provider)");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอน")
                .HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.RfidtagNumber)
                .HasComment("เลข RFIDTag")
                .HasColumnName("RFIDTagNumber");
            entity.Property(e => e.Running).HasComment("เลข Running ");
            entity.Property(e => e.ScrapValue)
                .HasDefaultValueSql("((1))")
                .HasComment("ราคาซาก (บาท)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขเครื่อง");
            entity.Property(e => e.SetName)
                .IsUnicode(false)
                .HasComment("ชื่อชุดครุภัณฑ์");
            entity.Property(e => e.Spec)
                .IsUnicode(false)
                .HasComment("ลักษณะ/คุณสมบัติ");
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รายละเอียดสถานที่จัดเก็บ/ใช้งาน");
            entity.Property(e => e.StorePlaceId).HasComment("สถานที่จัดเก็บ/ใช้งาน อ้างอิงตาราง MasterStorePlace.Id");
            entity.Property(e => e.SupplierFullAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ที่อยู่ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค");
            entity.Property(e => e.SupplierId).HasComment("ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ขาย/ผู้รับจ้าง/ผู้บริจาค");
            entity.Property(e => e.SupplierPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขโทรศัพท์ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarrantyEndDate)
                .HasComment("วันที่สิ้นสุดรับประกัน")
                .HasColumnType("datetime");
            entity.Property(e => e.WarrantyPeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("หน่วยเวลารับประกัน \r\n(D=วัน, M=เดือน, Y=ปี)");
            entity.Property(e => e.WarrantyStartDate)
                .HasComment("วันที่เริ่มรับประกัน")
                .HasColumnType("datetime");
            entity.Property(e => e.WarrantyTime).HasComment("ระยะเวลารับประกัน");
        });

        modelBuilder.Entity<AssetBorrow>(entity =>
        {
            entity.ToTable("AssetBorrow", tb => tb.HasComment("การยืม-คืนครุภัณฑ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetBorrowType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทการยืม (I=เพื่อใช้ภายในส่วนราชการ, O=เพื่อนำออกไปใช้ภายนอกส่วนราชการ, D=ยืมระหว่างกรม)");
            entity.Property(e => e.BorrowApproveDate)
                .HasComment("วันที่ผู้บังคับบัญชาของผู้ยืมพิจารณา")
                .HasColumnType("datetime");
            entity.Property(e => e.BorrowApproveOfficerId).HasComment("ผู้บังคับบัญชาของผู้ยืม อ้างอิง Officer.Id ");
            entity.Property(e => e.BorrowApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้บังคับบัญชาของผู้ยืม");
            entity.Property(e => e.BorrowDocument)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เอกสารการยืม");
            entity.Property(e => e.BorrowFromDate)
                .HasComment("ยืมตั้งแต่วันที่")
                .HasColumnType("datetime");
            entity.Property(e => e.BorrowerDivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("กลุ่ม/ฝ่าย/ส่วนของผู้ขอยืม");
            entity.Property(e => e.BorrowerEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("อีเมลของผู้ขอยืม");
            entity.Property(e => e.BorrowerMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เบอร์โทรศัพท์มือถือของผู้ขอยืม");
            entity.Property(e => e.BorrowerOfficerId).HasComment("ผู้ขอยืม อ้างอิง Officer.Id ");
            entity.Property(e => e.BorrowerOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ขอยืม");
            entity.Property(e => e.BorrowerOfficerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทเจ้าหน้าที่ของผู้ขอยืม (O=ข้าราชการ, E=พนักงานราชการ, P=ลูกจ้างประจำ)");
            entity.Property(e => e.BorrowerOrganizationId).HasComment("หน่วยงานผู้ขอยืม อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.BorrowerPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เบอร์โทรศัพท์ภายในของผู้ขอยืม");
            entity.Property(e => e.BorrowerPositionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้ขอยืม");
            entity.Property(e => e.BorrowerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทผู้ยืม (S=ตนเอง, O=ผู้อื่น)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("เนื่องจาก");
            entity.Property(e => e.DocumentDate)
                .HasComment("วันที่ใบยืม")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate)
                .HasComment("วันที่กำหนดส่งคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.LendApproveDate)
                .HasComment("วันที่ผอ./หัวหน้าของผู้ให้ยืมพิจารณา")
                .HasColumnType("datetime");
            entity.Property(e => e.LendApproveOfficerId).HasComment("ผอ./หัวหน้าของผู้ให้ยืม อ้างอิง Officer.Id ");
            entity.Property(e => e.LendApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผอ./หัวหน้าของผู้ให้ยืม");
            entity.Property(e => e.LendDate)
                .HasComment("วันที่ให้ยืม/เบิก")
                .HasColumnType("datetime");
            entity.Property(e => e.LenderOfficerId).HasComment("ผู้ให้ยืม/ผู้เบิก อ้างอิง Officer.Id ");
            entity.Property(e => e.LenderOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ให้ยืม/ผู้เบิก");
            entity.Property(e => e.LenderOrganizationId).HasComment("หน่วยงานผู้ให้ยืม อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.OtherEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("อีเมลของผู้อื่น (กรณียืมให้ผู้อื่น)");
            entity.Property(e => e.OtherMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เบอร์โทรศัพท์มือถือของผู้อื่น (กรณียืมให้ผู้อื่น)");
            entity.Property(e => e.OtherName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ - นามสกุลของผู้อื่น (กรณียืมให้ผู้อื่น)");
            entity.Property(e => e.OtherPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เบอร์โทรศัพท์ภายในของผู้อื่น (กรณียืมให้ผู้อื่น)");
            entity.Property(e => e.OtherPositionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งของผู้อื่น (กรณียืมให้ผู้อื่น)");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับมอบ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับมอบ อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับมอบ");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetBorrowItem>(entity =>
        {
            entity.ToTable("AssetBorrowItem", tb => tb.HasComment("ครุภัณฑ์ที่ยืม"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetBorrowId).HasComment("การยืม-คืนครุภัณฑ์ อ้างอิง AssetBorrow.Id");
            entity.Property(e => e.AssetBorrowStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการยืม (B=ยืม, R=ส่งคืน, C=รับคืน)");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.BorrowDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการยืม");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับคืน อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับคืน");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการคืน");
            entity.Property(e => e.ReturnOfficerId).HasComment("ผู้ส่งคืน อ้างอิง Officer.Id ");
            entity.Property(e => e.ReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ส่งคืน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetChange>(entity =>
        {
            entity.ToTable("AssetChange", tb => tb.HasComment("ประวัติการเปลี่ยนแปลงสินทรัพย์ (เบิก/โอน/ยืม-คืน/ส่งคืน/ตัดจำหน่าย)"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.ChangeDate)
                .HasComment("วันที่เปลี่ยนแปลง")
                .HasColumnType("datetime");
            entity.Property(e => e.ChangeDetail)
                .IsUnicode(false)
                .HasComment("รายละเอียดการเปลี่ยนแปลง");
            entity.Property(e => e.ChangeType).HasComment("ประเภทการเปลี่ยนแปลง \r\n(1=เบิก, 2=ยืม, 3=คืน, 4=โอน, 5=ส่งคืน, 6=ตัดจำหน่าย)\r\n");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasComment("รหัสที่อ้างอิง");
            entity.Property(e => e.ReferenceTable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อตารางที่อ้างอิง");
            entity.Property(e => e.Remark)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.ResponsibleOfficerId).HasComment("ผู้รับผิดชอบ อ้างอิง Officer.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetDepreciation>(entity =>
        {
            entity.ToTable("AssetDepreciation", tb => tb.HasComment("ค่าเสื่อมราคาสินทรัพย์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AccumDepreciation).HasComment("ค่าเสื่อมราคาสะสม");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DayNumber).HasComment("จำนวนวัน");
            entity.Property(e => e.DepreciationDate)
                .HasComment("วันเดือนปีที่คิดค่าเสื่อมราคา")
                .HasColumnType("datetime");
            entity.Property(e => e.NetValue).HasComment("มูลค่าสุทธิ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.YearDepreciation).HasComment("ค่าเสื่อมราคาประจำปี");
            entity.Property(e => e.YearRunning).HasComment("ปีที่");
        });

        modelBuilder.Entity<AssetMaintenance>(entity =>
        {
            entity.ToTable("AssetMaintenance", tb => tb.HasComment("ประวัติการซ่อมบำรุงสินทรัพย์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AccountingDate)
                .HasComment("วันที่ลงบัญชี")
                .HasColumnType("datetime");
            entity.Property(e => e.Amount).HasComment("จำนวน");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่ตรวจรับ")
                .HasColumnType("datetime");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetMaintenanceFormId).HasComment("ใบแจ้งซ่อม อ้างอิง AssetMaintenanceForm.Id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่แจ้งซ่อม");
            entity.Property(e => e.Cost)
                .HasComment("ค่าใช้จ่ายในการซ่อมบำรุง (บาท)")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaintenanceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด/รายการซ่อมบำรุง");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับแจ้งซ่อม/วันที่ซ่อมบำรุง")
                .HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.RequestDate)
                .HasComment("วันที่แจ้งซ่อม")
                .HasColumnType("datetime");
            entity.Property(e => e.SupplierId).HasComment("ผู้รับจ้างซ่อม อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับจ้างซ่อม");
            entity.Property(e => e.TotalCost)
                .HasComment("จำนวนเงินรวม")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetMaintenanceForm>(entity =>
        {
            entity.ToTable("AssetMaintenanceForm", tb => tb.HasComment("ใบแจ้งซ่อม"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.CheckDate)
                .HasComment("วันที่ตรวจสอบสภาพการชำรุด")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckOfficerId).HasComment("ผู้ตรวจสอบสภาพการชำรุด อ้างอิง Officer.Id ");
            entity.Property(e => e.CheckOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ตรวจสอบสภาพการชำรุด");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่แจ้งซ่อม");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.ExpectDate)
                .HasComment("วันที่คาดว่าจะ:ซ่อมแล้วเสร็จ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับแจ้งซ่อม")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveDirectorId).HasComment("หัวหน้าหน่วยงานพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับแจ้งซ่อม อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับแจ้งซ่อม");
            entity.Property(e => e.RequestDate)
                .HasComment("วันที่แจ้งซ่อม")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestDirectorId).HasComment("หัวหน้าหน่วยงานที่แจ้งซ่อม อ้างอิง Officer.Id ");
            entity.Property(e => e.RequestOfficerId).HasComment("ผู้แจ้งซ่อม อ้างอิง Officer.Id ");
            entity.Property(e => e.RequestOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้แจ้งซ่อม");
            entity.Property(e => e.RequestOrganizationId).HasComment("หน่วยงานที่แจ้งซ่อม อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ReturnCompleteDate)
                .HasComment("วันที่รับคืนสินทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งคืนสินทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("เรื่อง");
            entity.Property(e => e.SupplierId).HasComment("ผู้รับจ้างซ่อม อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับจ้างซ่อม");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetMaintenanceFormItem>(entity =>
        {
            entity.ToTable("AssetMaintenanceFormItem", tb => tb.HasComment("ครุภัณฑ์ที่แจ้งซ่อม"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AccountingDate)
                .HasComment("วันที่ลงบัญชี")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่ตรวจรับ")
                .HasColumnType("datetime");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetMaintenanceFormId).HasComment("ใบแจ้งซ่อม อ้างอิง AssetMaintenanceForm.Id");
            entity.Property(e => e.CheckDatail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ผลการตรวจสอบสภาพการชำรุด");
            entity.Property(e => e.CheckMaintenanceDatail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด");
            entity.Property(e => e.Cost)
                .HasComment("ค่าใช้จ่ายในการซ่อมบำรุง (บาท)")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)");
            entity.Property(e => e.Ischeck)
                .HasDefaultValueSql("((0))")
                .HasComment("ตรวจสอบสภาพการชำรุด (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)");
            entity.Property(e => e.MaintenanceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด/รายการซ่อมบำรุง");
            entity.Property(e => e.SupplierId).HasComment("ผู้รับจ้างซ่อม อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับจ้างซ่อม");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetMaintenanceFormItemList>(entity =>
        {
            entity.ToTable("AssetMaintenanceFormItemList", tb => tb.HasComment("รายการครุภัณฑ์แจ้งซ่อม"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Amount).HasComment("จำนวน");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetMaintenanceFormItemId).HasComment("ครุภัณฑ์ที่แจ้งซ่อม อ้างอิง AssetMaintenanceFormItem.Id");
            entity.Property(e => e.Cost)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaintenanceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด/รายการซ่อมบำรุง");
            entity.Property(e => e.TotalCost)
                .HasComment("จำนวนเงินรวม")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetRelation>(entity =>
        {
            entity.ToTable("AssetRelation", tb => tb.HasComment("ครุภัณฑ์ที่เกี่ยวข้อง"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupRunning).HasComment("เลข Running ของ Group");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetRequisition>(entity =>
        {
            entity.ToTable("AssetRequisition", tb => tb.HasComment("การเบิกจ่ายครุภัณฑ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveDate)
                .HasComment("วันที่สั่งจ่าย")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveOfficerId).HasComment("ผู้สั่งจ่าย อ้างอิง Officer.Id ");
            entity.Property(e => e.DeliverApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้สั่งจ่าย");
            entity.Property(e => e.DeliverDate)
                .HasComment("วันที่จ่ายพัสดุ")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverOfficerId).HasComment("ผู้จ่ายพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.DeliverOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้จ่ายพัสดุ");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.ExpectDate)
                .HasComment("ต้องการใช้ภายในวันที่")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับพัสดุ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับพัสดุ");
            entity.Property(e => e.RequestDate)
                .HasComment("วันที่ขอเบิก/วันที่เอกสาร")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestOfficerId).HasComment("ผู้เบิกพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.RequestOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้เบิกพัสดุ");
            entity.Property(e => e.RequestOrganizationId).HasComment("หน่วยงานที่เบิกพัสดุ อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รายละเอียดสถานที่จัดเก็บ/ใช้งาน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetRequisitionItem>(entity =>
        {
            entity.ToTable("AssetRequisitionItem", tb => tb.HasComment("ครุภัณฑ์ที่เบิกจ่าย"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetRequisitionId).HasComment("การเบิกจ่ายครุภัณฑ์ อ้างอิง AssetRequisition.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetReturn>(entity =>
        {
            entity.ToTable("AssetReturn", tb => tb.HasComment("การส่งคืนครุภัณฑ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AcceptDate)
                .HasComment("วันที่รับเป็นผู้เบิกต่อ")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่ตรวจสอบ")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveOfficerId).HasComment("ผู้ตรวจสอบ อ้างอิง Officer.Id ");
            entity.Property(e => e.ApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ตรวจสอบ");
            entity.Property(e => e.AssetReturnType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทการส่งคืน (R=ส่งคืนพัสดุ, C=เปลี่ยนผู้เบิก)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.CheckDate)
                .HasComment("วันที่ตรวจสอบสภาพการชำรุด")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckOfficerId).HasComment("ผู้ตรวจสอบสภาพการชำรุด อ้างอิง Officer.Id ");
            entity.Property(e => e.CheckOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ตรวจสอบสภาพการชำรุด");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่ใบส่งคืน");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NewResponsibleOfficerId).HasComment("ผู้เบิกต่อ อ้างอิง Officer.Id");
            entity.Property(e => e.NewResponsibleOrganizationId).HasComment("หน่วยงานของผู้เบิกต่อ อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับคืน อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับคืน");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnOfficerId).HasComment("ผู้ส่งคืนพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.ReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ส่งคืนพัสดุ");
            entity.Property(e => e.ReturnOrganizationId).HasComment("หน่วยงานที่ส่งคืนพัสดุ อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetReturnItem>(entity =>
        {
            entity.ToTable("AssetReturnItem", tb => tb.HasComment("ครุภัณฑ์ที่ส่งคืน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Amount).HasComment("จำนวน");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetReturnId).HasComment("การเบิกจ่ายครุภัณฑ์ อ้างอิง AssetRequisition.Id");
            entity.Property(e => e.CheckDatail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ผลการตรวจสอบสภาพการชำรุด");
            entity.Property(e => e.Cost)
                .HasComment("จำนวนเงิน (บาท)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ใช้งานได้แต่หมดความจำเป็นใช้งาน, N=ใช้งานไม่ได้/ชำรุด)");
            entity.Property(e => e.Ischeck)
                .HasDefaultValueSql("((0))")
                .HasComment("ตรวจสอบสภาพการชำรุด (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)");
            entity.Property(e => e.ReturnDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetTransfer>(entity =>
        {
            entity.ToTable("AssetTransfer", tb => tb.HasComment("การโอนครุภัณฑ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DestinationOrganizationId).HasComment("หน่วยงานที่รับโอน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("เนื่องจาก");
            entity.Property(e => e.DocumentDate)
                .HasComment("วันที่เอกสาร")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับโอน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับโอน อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับโอน");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.TransferDate)
                .HasComment("วันที่โอน")
                .HasColumnType("datetime");
            entity.Property(e => e.TransferOfficerId).HasComment("ผู้โอน อ้างอิง Officer.Id ");
            entity.Property(e => e.TransferOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้โอน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetTransferItem>(entity =>
        {
            entity.ToTable("AssetTransferItem", tb => tb.HasComment("ครุภัณฑ์ที่โอน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetTransferId).HasComment("การโอนครุภัณฑ์ อ้างอิง AssetTransfer.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NewAssetAcquisitionTypeId).HasComment("วิธีการได้มาใหม่หลังโอน อ้างอิง MasterAssetAcquisitionType.Id");
            entity.Property(e => e.NewAssetCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขครุภัณฑ์ใหม่หลังโอน");
            entity.Property(e => e.NewAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขสินทรัพย์ใหม่หลังโอน")
                .HasColumnName("NewAssetNumberGFMIS");
            entity.Property(e => e.NewCostCenterId).HasComment("ศูนย์ต้นทุนใหม่หลังโอน อ้างอิง MasterCostCenter.Id");
            entity.Property(e => e.NewOrganizationId).HasComment("หน่วยงานใหม่หลังโอน อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.NewReceiveDate)
                .HasComment("วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอนใหม่หลังโอน")
                .HasColumnType("datetime");
            entity.Property(e => e.OldAssetAcquisitionTypeId).HasComment("วิธีการได้มาเดิมก่อนโอน อ้างอิง MasterAssetAcquisitionType.Id");
            entity.Property(e => e.OldAssetCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขครุภัณฑ์เดิมก่อนโอน");
            entity.Property(e => e.OldAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขสินทรัพย์เดิมก่อนโอน")
                .HasColumnName("OldAssetNumberGFMIS");
            entity.Property(e => e.OldCostCenterId).HasComment("ศูนย์ต้นทุนเดิมก่อนโอน อ้างอิง MasterCostCenter.Id");
            entity.Property(e => e.OldCurrentBorrowerOfficerId).HasComment("ผู้ยืมก่อนโอน อ้างอิง Officer.Id");
            entity.Property(e => e.OldCurrentResponsibleOfficerId).HasComment("ผู้เบิกก่อนโอน อ้างอิง Officer.Id");
            entity.Property(e => e.OldOrganizationId).HasComment("หน่วยงานเดิมก่อนโอน อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.OldReceiveDate)
                .HasComment("วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอนเดิมก่อนโอน")
                .HasColumnType("datetime");
            entity.Property(e => e.TransferDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการโอน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetWriteOff>(entity =>
        {
            entity.ToTable("AssetWriteOff", tb => tb.HasComment("การตัดจำหน่ายครุภัณฑ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่ตัดจำหน่าย");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DestinationOrganizationId).HasComment("หน่วยงานที่รับโอน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ReferenceDate)
                .HasComment("วันที่ในเอกสารอ้างอิง")
                .HasColumnType("datetime");
            entity.Property(e => e.ReferenceDocument)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสารอ้างอิง");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WriteOffDate)
                .HasComment("วันที่ตัดจำหน่าย")
                .HasColumnType("datetime");
            entity.Property(e => e.WriteOffDetail)
                .IsUnicode(false)
                .HasComment("รายละเอียดเพิ่มเติม/หมายเหตุ");
            entity.Property(e => e.WriteOffStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการตัดจำหน่าย (D=ร่าง, C=ยืนยันการตัดจำหน่าย)");
            entity.Property(e => e.WriteOffType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทการตัดจำหน่าย (S=ขาย, D=บริจาค, T=โอนให้หน่วยงานนอกสป., E=แลกเปลี่ยน, L=สูญหาย)");
            entity.Property(e => e.WriteOffTypeId).HasComment("ประเภทการตัดจำหน่าย อ้างอิง MasterWriteOffType.Id");
        });

        modelBuilder.Entity<AssetWriteOffItem>(entity =>
        {
            entity.ToTable("AssetWriteOffItem", tb => tb.HasComment("ครุภัณฑ์ที่ตัดจำหน่าย"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("สินทรัพย์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetWriteOffId).HasComment("การตัดจำหน่ายครุภัณฑ์ อ้างอิง AssetWriteOff.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsUsable)
                .HasDefaultValueSql("((1))")
                .HasComment("สภาพทรัพย์สิน (True=ใช้งานได้แต่หมดความจำเป็นใช้งาน, N=ใช้งานไม่ได้/ชำรุด)");
            entity.Property(e => e.Remark)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ลักษณะการชำรุด");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetDisbursementPlan>(entity =>
        {
            entity.ToTable("BudgetDisbursementPlan", tb => tb.HasComment("แผนการใช้จ่ายงบประมาณ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetRequestId).HasComment("คำของบประมาณ อ้างอิง BudgetRequest.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.ChangeNumber).HasComment("การปรับแผนครั้งที่");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่คำขอ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsChange).HasComment("เป็นการปรับแผน (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ParentBudgetDisbursementPlan).HasComment("รหัสอ้างอิงในระบบที่ไปสังกัด อ้างอิง BudgetDisbursementPlan.Id");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetDisbursementPlanItem>(entity =>
        {
            entity.ToTable("BudgetDisbursementPlanItem", tb => tb.HasComment("รายละเอียดแผนการใช้จ่ายงบประมาณ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AllocateAmount)
                .HasComment("จำนวนเงินงบประมาณที่ได้รับจัดสรรของกองทุนอนุรักษ์ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.BudgetDisbursementPlanId).HasComment("แผนการใช้จ่ายงบประมาณ อ้างอิง BudgetDisbursementPlan.Id");
            entity.Property(e => e.BudgetGovernmentId).HasComment("รายการเงินงบประมาณแผ่นดิน อ้างอิง BudgetGovernment.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณที่ดำเนินการ");
            entity.Property(e => e.Condition)
                .IsUnicode(false)
                .HasComment("เงื่อนไข");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DisbursementDetail)
                .IsUnicode(false)
                .HasComment("รายการที่เบิก - จ่าย");
            entity.Property(e => e.IsEditable).HasComment("การแก้ไขค่า (True=แก้ไขได้, False=ห้ามแก้ไข)");
            entity.Property(e => e.Month).HasComment("เดือนที่ดำเนินการ (1=มกราคม, ..., 12=ธันวาคม)");
            entity.Property(e => e.Period).HasComment("งวดที่");
            entity.Property(e => e.PlanAmount)
                .HasComment("จำนวนเงิน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.Quantity).HasComment("จำนวนราย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.Year).HasComment("ปีปฏิทินที่ดำเนินการ");
        });

        modelBuilder.Entity<BudgetGovernment>(entity =>
        {
            entity.ToTable("BudgetGovernment", tb => tb.HasComment("รายการเงินงบประมาณแผ่นดิน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ActivityCodeId).HasComment("กิจกรรมหลัก อ้างอิง MasterActivityCode.Id");
            entity.Property(e => e.BudgetDetail)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("รายการ");
            entity.Property(e => e.BudgetExpenseTypeId).HasComment("งบประมาณจำแนกตามงบรายจ่าย อ้างอิง MasterBudgetExpenseType.Id");
            entity.Property(e => e.BudgetFormTypeId).HasComment("แบบฟอร์มคำของบประมาณ อ้างอิง MasterBudgetFormType.Id");
            entity.Property(e => e.BudgetGovernmentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทงบแผ่นดิน (1 = สป. 2 = งบเบิกแทน 3 = คำขอเพิ่มเติม)");
            entity.Property(e => e.BudgetRequestId).HasComment("คำของบประมาณ อ้างอิง BudgetRequest.Id");
            entity.Property(e => e.BudgetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะดำเนินการ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่คำขอ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.KeptCentral)
                .HasComment("กันไว้ที่ส่วนกลาง")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.Reason)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("เหตุผลความจำเป็น");
            entity.Property(e => e.RefundAmount)
                .HasComment("คืนเงินเหลือจ่าย (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.TotalAllocateAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalAllocateAmountCentral)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรรส่วนกลาง (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalAllocateAmountProvince)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรรจังหวัด (บาท) ")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount)
                .HasComment("รวมเงินงบประมาณคงเหลือ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount)
                .HasComment("รวมเงินงบประมาณที่ผูกพัน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount)
                .HasComment("รวมเงินงบประมาณที่เบิกจ่าย (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับทั้งหมด (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalRequestAmount)
                .HasComment("รวมเงินคำของบประมาณ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount)
                .HasComment("รวมเงินงบประมาณโอนเปลี่ยนแปลง (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetGovernmentItem>(entity =>
        {
            entity.ToTable("BudgetGovernmentItem", tb => tb.HasComment("รายการเงินงบประมาณแผ่นดิน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ActivityCodeId).HasComment("กิจกรรมหลัก อ้างอิง MasterActivityCode.Id");
            entity.Property(e => e.BudgetExpenseTypeId).HasComment("งบประมาณจำแนกตามงบรายจ่าย อ้างอิง MasterBudgetExpenseType.Id");
            entity.Property(e => e.BudgetFormTypeId).HasComment("แบบฟอร์มคำของบประมาณ อ้างอิง MasterBudgetFormType.Id");
            entity.Property(e => e.BudgetGovernmentId).HasComment("เงินงบประมาณแผ่นดินของหน่วยงาน อ้างอิง BudgetGovernment.Id");
            entity.Property(e => e.BudgetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะดำเนินการ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่คำขอ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate)
                .HasComment("อัตราที่ตั้ง (ราคาต่อหน่วย)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("รายละเอียดค่าใช้จ่าย");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Quantity).HasComment("หน่วยนับ (จำนวนคน)");
            entity.Property(e => e.QuantityUnit).HasComment("จำนวนหน่วย");
            entity.Property(e => e.QuantityUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.TotalAmount)
                .HasComment("รวมจำนวนเงิน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetReceive>(entity =>
        {
            entity.ToTable("BudgetReceive", tb => tb.HasComment("จัดสรรให้หน่วยงาน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetDisbursementPlanItemId).HasComment("การเบิกจ่ายเงิน งาน/โครงการกองทุนอนุรักษ์ อ้างอิง BudgetDisbursementPlanItem.Id");
            entity.Property(e => e.BudgetGovernmentId).HasComment("เงินงบประมาณแผ่นดินของหน่วยงาน อ้างอิง BudgetGovernment.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.TotalAllocateAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount)
                .HasComment("รวมเงินงบประมาณคงเหลือ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount)
                .HasComment("รวมเงินงบประมาณที่ผูกพัน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount)
                .HasComment("รวมเงินงบประมาณที่เบิกจ่าย (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับทั้งหมด (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount)
                .HasComment("รวมเงินงบประมาณโอนเปลี่ยนแปลง (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetRequest>(entity =>
        {
            entity.ToTable("BudgetRequest", tb => tb.HasComment("คำของบประมาณ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetTypeId).HasComment("ประเภทงบ อ้างอิง MasterBudgetType.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่คำขอ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.TotalAllocateAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount)
                .HasComment("รวมเงินงบประมาณคงเหลือ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount)
                .HasComment("รวมเงินงบประมาณที่ผูกพัน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount)
                .HasComment("รวมเงินงบประมาณที่เบิกจ่าย (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับทั้งหมด (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalRequestAmount)
                .HasComment("รวมเงินคำของบประมาณ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount)
                .HasComment("รวมเงินงบประมาณโอนเปลี่ยนแปลง (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterActivityCode>(entity =>
        {
            entity.ToTable("MasterActivityCode", tb => tb.HasComment("กิจกรรม"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อย่อกิจกรรมหลัก");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสกิจกรรมหลัก");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัด")
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อกิจกรรมหลัก");
            entity.Property(e => e.OutputCodeId).HasComment("ผลผลิต/โครงการ อ้างอิง MasterOutputCode.Id");
            entity.Property(e => e.Target)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterActivityLogType>(entity =>
        {
            entity.ToTable("MasterActivityLogType", tb => tb.HasComment("ประเภทการดำเนินการในระบบ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทการดำเนินการในระบบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAmphur>(entity =>
        {
            entity.ToTable("MasterAmphur", tb => tb.HasComment("อำเภอ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AmphurCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสอำเภอที่ใช้ในกรมการปกครอง");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่ออำเภอ ภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่ออำเภอ ภาษาไทย");
            entity.Property(e => e.ProvinceId).HasComment("จังหวัด อ้างอิง MasterProvince.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAssetAcquisitionType>(entity =>
        {
            entity.ToTable("MasterAssetAcquisitionType", tb => tb.HasComment("การได้มาของสินทรัพย์"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อวิธีการได้มาของสินทรัพย์");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAssetBudgetType>(entity =>
        {
            entity.ToTable("MasterAssetBudgetType", tb => tb.HasComment("แหล่งเงินในการได้รับทรัพย์สิน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อแหล่งเงินในการได้รับทรัพย์สิน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAssetClass>(entity =>
        {
            entity.ToTable("MasterAssetClass", tb => tb.HasComment("หมวดหมู่ย่อยครุภัณฑ์"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AssetTypeId).HasComment("หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id");
            entity.Property(e => e.AssetTypeSubId).HasComment("หมวดหมู่ครุภัณฑ์รายการย่อย อ้างอิง MasterAssetTypeSub.Id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขหมวด");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Depreciation)
                .HasComment("อัตราค่าเสื่อม (ร้อยละ)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.LifeTimeDepreciation).HasComment("อายุการใช้งาน(ค่าเสื่อม)");
            entity.Property(e => e.LifeTimeUse).HasComment("อายุการใช้งาน (ทดแทน)");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหมวดหมู่ย่อย ภาษาไทย");
            entity.Property(e => e.SequenceNumber).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAssetType>(entity =>
        {
            entity.ToTable("MasterAssetType", tb => tb.HasComment("หมวดหมู่ครุภัณฑ์"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AssetCategory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("กลุ่มสินทรัพย์ (B=อาคารและสิ่งปลูกสร้าง, C=รถยนต์, D=ครุภัณฑ์, I=สินทรัพย์ไม่มีตัวตน)");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสประเภทครุภัณฑ์");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Depreciation)
                .HasComment("อัตราค่าเสื่อม (ร้อยละ)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.LifeTimeDepreciation).HasComment("อายุการใช้งาน(ค่าเสื่อม)");
            entity.Property(e => e.LifeTimeMax).HasComment("อายุการใช้งานอย่างสูง (ปี)");
            entity.Property(e => e.LifeTimeMin).HasComment("อายุการใช้งานอย่างต่ำ (ปี)");
            entity.Property(e => e.LifeTimeUse).HasComment("อายุการใช้งาน (ทดแทน)");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทครุภัณฑ์ภาษาไทย");
            entity.Property(e => e.SequenceNumber).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterAssetTypeSub>(entity =>
        {
            entity.ToTable("MasterAssetTypeSub", tb => tb.HasComment("หมวดหมู่ครุภัณฑ์รายการย่อย"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AssetTypeId).HasComment("หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสประเภทครุภัณฑ์");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Depreciation)
                .HasComment("อัตราค่าเลื่อม (ร้อยละ)")
                .HasColumnType("numeric(15, 2)");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.LifeTimeDepreciation).HasComment("อายุการใช้งาน(ค่าเสื่อม)");
            entity.Property(e => e.LifeTimeUse).HasComment("อายุการใช้งาน (ทดแทน)");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทครุภัณฑ์ภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterBank>(entity =>
        {
            entity.ToTable("MasterBank", tb => tb.HasComment("ธนาคาร"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อธนาคาร");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสธนาคาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อธนาคาร ภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อธนาคาร ภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterBudgetExpenseType>(entity =>
        {
            entity.ToTable("MasterBudgetExpenseType", tb => tb.HasComment("รายการค่าใช้จ่าย"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetExpenseLevel).HasComment("ระดับชั้นของรายการค่าใช้จ่าย");
            entity.Property(e => e.BudgetFormTypeId).HasComment("แบบฟอร์มคำของบประมาณ อ้างอิง MasterBudgetFormType.Id");
            entity.Property(e => e.BudgetTypeId).HasComment("ประเภทงบ อ้างอิง MasterBudgetType.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpenseTypeId).HasComment("ประเภทงบรายจ่าย อ้างอิง MasterExpenseType.Id");
            entity.Property(e => e.IsParent).HasComment("มีรายการค่าใช้จ่ายในสังกัดหรือไม่ (True=มี, False=ไม่มี)");
            entity.Property(e => e.MoneySourceId).HasComment("แหล่งเงิน อ้างอิง MasterMoneySource.Id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อรายการค่าใช้จ่าย");
            entity.Property(e => e.OutputCodeId).HasComment("ผลผลิต/โครงการ อ้างอิง MasterOutputCode.Id");
            entity.Property(e => e.ParentId).HasComment("รายการค่าใช้จ่ายที่รายการนี้ไปสังกัด อ้างอิง MasterBudgetExpenseType.Id");
            entity.Property(e => e.StrategicPlanCodeId).HasComment("แผนงาน อ้างอิง MasterStrategicPlanCode.Id");
            entity.Property(e => e.StrategyCodeId).HasComment("ยุทธศาสตร์ อ้างอิง MasterStrategyCode.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterBudgetFormType>(entity =>
        {
            entity.ToTable("MasterBudgetFormType", tb => tb.HasComment("แบบฟอร์มคำของบประมาณ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสแบบฟอร์มคำของบประมาณ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อแบบฟอร์มคำของบประมาณ");
            entity.Property(e => e.SequenceNumber).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterBudgetType>(entity =>
        {
            entity.ToTable("MasterBudgetType", tb => tb.HasComment("ประเภทงบ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทงบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterConsistency>(entity =>
        {
            entity.ToTable("MasterConsistency", tb => tb.HasComment("ความสอดคล้องกับวัตถุประสงค์ของกองทุน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("รายละเอียดความสอดคล้อง");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("วัตถุประสงค์");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterCostCenter>(entity =>
        {
            entity.ToTable("MasterCostCenter", tb => tb.HasComment("ศูนย์ต้นทุน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อศูนย์ต้นทุน");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสพื้นที่");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสศูนย์ต้นทุน");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อศูนย์ต้นทุนภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterDocumentType>(entity =>
        {
            entity.ToTable("MasterDocumentType", tb => tb.HasComment("ประเภทเอกสาร"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสหมวดพัสดุ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentGroup).HasComment("กลุ่มเอกสาร (1=ครุภัณฑ์)");
            entity.Property(e => e.NameThai)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("ชื่อหมวดพัสดุ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterExpenseType>(entity =>
        {
            entity.ToTable("MasterExpenseType", tb => tb.HasComment("ประเภทงบรายจ่าย"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetTypeId).HasComment("ประเภทเงิน อ้างอิง MasterBudgetType.Id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสประเภทงบรายจ่าย");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทงบรายจ่าย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterFuelType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MasterCarfuel");

            entity.ToTable("MasterFuelType", tb => tb.HasComment("ประเภทน้ำมันเชื้อเพลิงยานพาหนะ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทน้ำมันเชื้อเพลิง");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterFund>(entity =>
        {
            entity.ToTable("MasterFund", tb => tb.HasComment("กองทุน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อกองทุน");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสกองทุน");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อกองทุน ภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อกองทุน ภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterLandType>(entity =>
        {
            entity.ToTable("MasterLandType", tb => tb.HasComment("ประเภทที่ดิน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสประเภทที่ดิน");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทที่ดิน ภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterMaterial>(entity =>
        {
            entity.ToTable("MasterMaterial", tb => tb.HasComment("วัสดุ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสวัสดุ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaterialDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.MaterialGroupId).HasComment("หมวดพัสดุ อ้างอิง MasterMaterialGroup.Id");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อวัสดุ");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterMaterialGpsc>(entity =>
        {
            entity.ToTable("MasterMaterialGpsc", tb => tb.HasComment("รหัส GPSC"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.ClassNameThai)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("คำอธิบายลักษณะกลุ่มผลิตภัณฑ์");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัส GPSC")
                .HasColumnName("GPSCCode");
            entity.Property(e => e.MaterialGroupCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสหมวดพัสดุ");
            entity.Property(e => e.MaterialGroupId).HasComment("หมวดพัสดุ อ้างอิง MasterMaterialGroup.Id");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("คำอธิบายรหัส GPSC");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterMaterialGroup>(entity =>
        {
            entity.ToTable("MasterMaterialGroup", tb => tb.HasComment("หมวดพัสดุ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสหมวดพัสดุ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("ชื่อหมวดพัสดุ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterMoneySource>(entity =>
        {
            entity.ToTable("MasterMoneySource", tb => tb.HasComment("แหล่งเงิน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อแหล่งเงิน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterNamePrefix>(entity =>
        {
            entity.ToTable("MasterNamePrefix", tb => tb.HasComment("คำนำหน้าชื่อ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy).HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NamePrefix)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("คำนำหน้าชื่อ ภาษาไทย");
            entity.Property(e => e.NamePrefixEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("คำนำหน้าชื่อ ภาษาอังกฤษ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterOrganization>(entity =>
        {
            entity.ToTable("MasterOrganization", tb => tb.HasComment("หน่วยงาน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อหน่วยงาน");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสพื้นที่");
            entity.Property(e => e.BudgetSequence).HasComment("การเรียงลำดับในระบบงบประมาณ");
            entity.Property(e => e.CostCenterId).HasComment("ศูนย์ต้นทุน อ้างอิง MasterCostCenter.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DirectorId).HasComment("ผู้อำนวยการ อ้างอิง Officer.Id");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานภาษาไทย");
            entity.Property(e => e.OrganizationCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสหน่วยงาน");
            entity.Property(e => e.OrganizationLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ระดับชั้นหน่วยงาน (1=สำนักงาน/กรม, 2=สำนัก/กอง/ศูนย์, 3=ส่วน/กลุ่ม/ฝ่าย)");
            entity.Property(e => e.ParentOrganization).HasComment("รหัสหน่วยงานต้นสังกัด อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterOutputCode>(entity =>
        {
            entity.ToTable("MasterOutputCode", tb => tb.HasComment("ผลผลิต/โครงการ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อผลผลิต/โครงการ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสผลผลิต/โครงการ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัด")
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผลผลิต/โครงการ");
            entity.Property(e => e.OutputType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทผลผลิต/โครงการ (O=ผลผลิต, P=โครงการ)");
            entity.Property(e => e.StrategicPlanCodeId).HasComment("แผนงาน อ้างอิง MasterStrategicPlanCode.Id");
            entity.Property(e => e.Target)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterPosition>(entity =>
        {
            entity.ToTable("MasterPosition", tb => tb.HasComment("ตำแหน่ง"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงตำแหน่ง");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PositionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อตำแหน่ง");
            entity.Property(e => e.PositionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทตำแหน่ง W=ตำแหน่งทางสายงาน, E=ตำแหน่งบริหาร");
            entity.Property(e => e.Sequence).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterProcurementMethod>(entity =>
        {
            entity.ToTable("MasterProcurementMethod", tb => tb.HasComment("วิธีจัดซื้อจัดจ้าง"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อวิธีจัดซื้อจัดจ้าง");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อวิธีจัดซื้อจัดจ้าง ภาษาไทย");
            entity.Property(e => e.SequenceNumber).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterProcurementMethodStep>(entity =>
        {
            entity.ToTable("MasterProcurementMethodStep", tb => tb.HasComment("ขั้นตอนการจัดซื้อจัดจ้าง"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อวิธีจัดซื้อจัดจ้าง ภาษาไทย");
            entity.Property(e => e.ProcurementMethodId).HasComment("วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id");
            entity.Property(e => e.SequenceNumber).HasComment("การเรียงลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterProvince>(entity =>
        {
            entity.ToTable("MasterProvince", tb => tb.HasComment("จังหวัด"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อจังหวัด ภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อจังหวัด ภาษาไทย");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสจังหวัดที่ใช้ในกรมการปกครอง");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterReturnReason>(entity =>
        {
            entity.ToTable("MasterReturnReason", tb => tb.HasComment("เหตุผลในการส่งคืน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("เหตุผลในการส่งคืน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterStandardPrice>(entity =>
        {
            entity.ToTable("MasterStandardPrice", tb => tb.HasComment("ราคาครุภัณฑ์มาตรฐาน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงชื่อระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)");
            entity.Property(e => e.AssetClassId).HasComment("หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id");
            entity.Property(e => e.AssetTypeId).HasComment("หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อรายการ");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UnitPrice)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MasterMaterialStatus");

            entity.ToTable("MasterStatus", tb => tb.HasComment("สถานะ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("สถานะ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterStorePlace>(entity =>
        {
            entity.ToTable("MasterStorePlace", tb => tb.HasComment("สถานที่จัดเก็บ/ใช้งาน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสสถานที่จัดเก็บ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชั้น");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อสถานที่จัดเก็บใช้งาน");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterStrategicPlanCode>(entity =>
        {
            entity.ToTable("MasterStrategicPlanCode", tb => tb.HasComment("แผนงาน"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อแผนงาน");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสแผนงาน");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัด")
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อแผนงาน");
            entity.Property(e => e.StrategyCodeId).HasComment("ยุทธศาสตร์ อ้างอิง MasterStrategyCode.Id");
            entity.Property(e => e.Target)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterStrategyCode>(entity =>
        {
            entity.ToTable("MasterStrategyCode", tb => tb.HasComment("ยุทธศาสตร์"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อย่อยุทธศาสตร์");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสยุทธศาสตร์");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัด")
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อยุทธศาสตร์");
            entity.Property(e => e.Target)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterSystemName>(entity =>
        {
            entity.ToTable("MasterSystemName", tb => tb.HasComment("ชื่อระบบ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงชื่อระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อระบบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterTambon>(entity =>
        {
            entity.ToTable("MasterTambon", tb => tb.HasComment("ตำบล"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.AmphurId).HasComment("อำเภอ อ้างอิง MasterAmphur.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate)
                .HasComment("วันที่เริ่มต้นใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate)
                .HasComment("วันที่สิ้นสุดการใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.NameEnglish)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อตำบล ภาษาอังกฤษ");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อตำบล ภาษาไทย");
            entity.Property(e => e.TambonCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสตำบลที่ใช้ในกรมการปกครอง");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("รหัสไปรษณีย์");
        });

        modelBuilder.Entity<MasterUnit>(entity =>
        {
            entity.ToTable("MasterUnit", tb => tb.HasComment("หน่วยนับ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Egpactive)
                .HasComment("การใช้งานในระบบ e-GP (True=ใช้งาน, False=ไม่ใช้งาน)")
                .HasColumnName("EGPActive");
            entity.Property(e => e.Egpid)
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ e-GP")
                .HasColumnName("EGPID");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยนับ ภาษาไทย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterWarehouse>(entity =>
        {
            entity.ToTable("MasterWarehouse", tb => tb.HasComment("คลังเก็บวัสดุ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงคลังที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)");
            entity.Property(e => e.CreateBy).HasComment("ผู้สร้าง อ้างอิง SysUser.Id");
            entity.Property(e => e.CreateOn)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อคลัง");
            entity.Property(e => e.OrganizationId).HasComment("รหัสหน่วยงาน อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SysUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด");
        });

        modelBuilder.Entity<MasterWriteOffType>(entity =>
        {
            entity.ToTable("MasterWriteOffType", tb => tb.HasComment("ประเภทการตัดจำหน่าย"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทการตัดจำหน่าย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MaterialBorrow>(entity =>
        {
            entity.ToTable("MaterialBorrow", tb => tb.HasComment("ใบยืมวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ApproveBy).HasComment("ผู้อนุมัติยืม อ้างอิง Officer.Id");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.BorrowDate)
                .HasComment("วันที่ยืม")
                .HasColumnType("datetime");
            entity.Property(e => e.BorrowerBy).HasComment("ผู้ยืม อ้างอิง Officer.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่เอกสาร");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งกลับ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("เหตุผลที่ส่งกลับ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.SourceOrganizationId).HasComment("หน่วยงานที่ยืม อ้างอิง Organization.Id ");
            entity.Property(e => e.StatusApprove)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการพิจารณา : Y = อนุมัติ, N = ไม่อนุมัติ ");
            entity.Property(e => e.StatusId).HasComment("สถานะ อ้างอิง MasterStatus");
            entity.Property(e => e.SubmitDate)
                .HasComment("วันที่ส่งเรื่อง")
                .HasColumnType("datetime");
            entity.Property(e => e.TargetOrganizationId).HasComment("หน่วยงานที่ให้ยืม อ้างอิง Organization.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MaterialBorrowItem>(entity =>
        {
            entity.ToTable("MaterialBorrowItem", tb => tb.HasComment("รายการยืมวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BorrowAmount).HasComment("จำนวนที่ขอยืม");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaterialBorrowId).HasComment("รหัสใบยืมวัสดุ อ้างอิง MaterialBorrow.Id");
            entity.Property(e => e.MaterialId).HasComment("รหัสวัสดุ อ้างอิง MasterMaterial.Id");
            entity.Property(e => e.ReceiveAmount).HasComment("จำนวนที่จ่ายจริง");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.ReturnBy).HasComment("ผู้ส่งคืน อ้างอิง SystemUser.Id");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnReceiveDate)
                .HasComment("วันที่รับคืน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturneeBy).HasComment("ผู้รับคืน อ้างอิง SystemUser.Id");
            entity.Property(e => e.StatusId).HasComment("สถานะ 1 = ยืม, 2 = ส่งคืน, 3 = รับคืน");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MaterialIn>(entity =>
        {
            entity.ToTable("MaterialIn", tb => tb.HasComment("ใบรับพัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่กดยืนยันรับ")
                .HasColumnType("datetime");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่ใบรับ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsPurchasingOrder).HasComment("จัดซื้อตามคำสั่งซื้อของหน่วยงาน (ใช่ = True, ไม่ใช่ = False)");
            entity.Property(e => e.MaterialInType).HasComment("ประเภทการรับ 1 = รับเข้าจากหน่วยจัดซื้อ, 2 = รับเข้าจากหน่วยงาน");
            entity.Property(e => e.ProcurementNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา/ใบสั่งซื้อ/ใบสั่งจ้าง");
            entity.Property(e => e.PurchaseDate)
                .HasComment("วันที่สัญญา/ใบสั่งซื้อ/ใบสั่งจ้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PurchasingWareHouseId).HasComment("คลังวัสดุที่สั่งซื้อ อ้างอิง MasterWarehouse.Id");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับ")
                .HasColumnType("datetime");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ : N = New (สร้างใหม่), A = Approve (ยืนยันรับ)");
            entity.Property(e => e.SupplierId).HasComment("รหัสผู้จำหน่าย อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasComment("รหัสคลังเก็บวัสดุ อ้างอิง MasterWarehouse.Id");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด");
        });

        modelBuilder.Entity<MaterialInItem>(entity =>
        {
            entity.ToTable("MaterialInItem", tb => tb.HasComment("รายการวัสดุที่รับเข้า"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("รหัส GPSC")
                .HasColumnName("GPSCCode");
            entity.Property(e => e.IncludeVat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("คิด VAT : Y = คิด, N = ไม่คิด")
                .HasColumnName("IncludeVAT");
            entity.Property(e => e.MaterialId).HasComment("รายการวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.MaterialInId).HasComment("ใบรับพัสดุ อ้างอิง MaterialIn.Id");
            entity.Property(e => e.ReceiveAmount).HasComment("จำนวนที่รับ");
            entity.Property(e => e.TotalPrice)
                .HasComment("ราคารวม")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UnitPrice)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UnitPriceNoVat)
                .HasComment("ราคาก่อน VAT")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.Vat)
                .HasDefaultValueSql("((7))")
                .HasComment("VAT (เปอร์เซ็นต์)")
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<MaterialRequisition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Requisition");

            entity.ToTable("MaterialRequisition", tb => tb.HasComment("เบิกจ่ายวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ApproveDate)
                .HasComment("วันที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.ApproveRequestBy).HasComment("ผู้อนุมัติเบิก อ้างอิง Officer.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.CancelDate)
                .HasComment("วันที่ยกเลิก")
                .HasColumnType("datetime");
            entity.Property(e => e.CancelRemark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("หมายเหตุการยกเลิก");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่ใบเบิก");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveDate)
                .HasComment("วันที่สั่งจ่าย")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveOfficerId).HasComment("ผู้สั่งจ่าย อ้างอิง Officer.Id ");
            entity.Property(e => e.DeliverApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้สั่งจ่าย");
            entity.Property(e => e.DeliverDate)
                .HasComment("วันที่จ่ายพัสดุ")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverOfficerId).HasComment("ผู้จ่ายพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.DeliverOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้จ่ายพัสดุ");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.ExpectDate)
                .HasComment("ต้องการใช้ภายในวันที่")
                .HasColumnType("datetime");
            entity.Property(e => e.OrganizationId).HasComment("รหัสสำนัก อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับพัสดุ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerId).HasComment("ผู้รับพัสดุ อ้างอิง Officer.Id ");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้รับพัสดุ");
            entity.Property(e => e.RequestBy).HasComment("ผู้ขอเบิก อ้างอิง Officer.Id");
            entity.Property(e => e.RequestDate)
                .HasComment("วันที่ขอเบิก")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestType).HasComment("ประเภทการเบิก 1 = เบิกจากหน่วยจัดซื้อ, 2 = เบิกจากหน่วยงาน");
            entity.Property(e => e.ReturnBy).HasComment("เจ้าหน้าที่ผู้ส่งกลับ อ้างอิง Officer.Id");
            entity.Property(e => e.ReturnDate)
                .HasComment("วันที่ส่งกลับ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการส่งกลับ");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.StatusApprove)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการพิจารณา : Y = อนุมัติ, N = ไม่อนุมัติ ");
            entity.Property(e => e.StatusId).HasComment("สถานะดำเนินการ อ้างอิง MasterStatus.Id");
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รายละเอียดสถานที่จัดเก็บ/ใช้งาน");
            entity.Property(e => e.SubmitDate)
                .HasComment("วันที่ส่งเรื่อง")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasComment("รหัสคลังเก็บวัสดุ อ้างอิง MasterWarehouse.Id");
        });

        modelBuilder.Entity<MaterialRequisitionItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RequisitionItem");

            entity.ToTable("MaterialRequisitionItem", tb => tb.HasComment("รายการเบิกจ่ายวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("รหัส GPSC")
                .HasColumnName("GPSCCode");
            entity.Property(e => e.MaterialId).HasComment("รายการวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.MaterialInItemId).HasComment("วัสดุที่รับเข้า อ้างอิง MaterialInItem.Id");
            entity.Property(e => e.MaterialStockId).HasComment("รหัสสต๊อก อ้างอิง MaterialStock.Id");
            entity.Property(e => e.ReceiveAmount).HasComment("จำนวนที่จ่ายจริง");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.RequestAmount).HasComment("จำนวนที่ขอเบิก");
            entity.Property(e => e.RequisitionId).HasComment("ใบเบิก อ้างอิง MaterialRequisition.Id");
            entity.Property(e => e.TotalPrice)
                .HasComment("ราคารวม")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UnitPrice)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MaterialSafetyStock>(entity =>
        {
            entity.ToTable("MaterialSafetyStock", tb => tb.HasComment("คลังเก็บวัสดุ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy).HasComment("ผู้สร้าง อ้างอิง SysUser.Id");
            entity.Property(e => e.CreateOn)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DrawableAmount).HasComment("จำนวนที่เบิกได้ ไม่เกินต่อครั้ง");
            entity.Property(e => e.MaterialId).HasComment("รหัสวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.MaxStock).HasComment("จำนวนสูงสุด");
            entity.Property(e => e.MinStock).HasComment("จำนวนต่ำสุด");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SysUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasComment("รหัสคลัง อ้างอิง MasterWarehouse");
        });

        modelBuilder.Entity<MaterialStock>(entity =>
        {
            entity.ToTable("MaterialStock", tb => tb.HasComment("สต๊อกวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Available).HasComment("จำนวนคงเหลือในล็อตนั้น");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaterialId).HasComment("รหัสวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.MaterialInItemId).HasComment("รายการจากใบรับเข้าคลัง อ้างอิง MaterialInItem.Id");
            entity.Property(e => e.ReceiveDate)
                .HasComment("วันที่รับ")
                .HasColumnType("datetime");
            entity.Property(e => e.RequisitionId).HasComment("ใบเบิก อ้างอิง MaterialRequisition.Id");
            entity.Property(e => e.RequisitionItemId).HasComment("รายการจากใบเบิก อ้างอิง MaterialRequisitionItem.Id ดูว่ารับเข้าจากใบเบิกรายการใด");
            entity.Property(e => e.StockIn).HasComment("จำนวนรับเข้าทั้งหมดในล็อตนั้น");
            entity.Property(e => e.StockOut).HasComment("จำนวนเบิกออกทั้งหมดในล็อตนั้น");
            entity.Property(e => e.TotalPrice)
                .HasComment("ราคารวม")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UnitPrice)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UnitPriceNoVat)
                .HasComment("ราคาก่อน VAT")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasComment("คลังที่เก็บวัสดุ อ้างอิง MasterWarehouse.Id");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด");
        });

        modelBuilder.Entity<MaterialStockMovement>(entity =>
        {
            entity.ToTable("MaterialStockMovement", tb => tb.HasComment("การเคลื่อนไหวของวัสดุ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AfterSourceMaterial).HasComment("จำนวนหลังปรับปรุงของคลังต้นทาง");
            entity.Property(e => e.AfterTargetMaterial).HasComment("จำนวนหลังปรับปรุงของคลังปลายทาง");
            entity.Property(e => e.Amount).HasComment("จำนวนที่รับ-จ่าย");
            entity.Property(e => e.BeforeSourceMaterial).HasComment("จำนวนก่อนปรับปรุงของคลังต้นทาง");
            entity.Property(e => e.BeforeTargetMaterial).HasComment("จำนวนก่อนปรับปรุงของคลังปลายทาง");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MaterialId).HasComment("รหัสวัสดุ อ้างอิง Material.Id");
            entity.Property(e => e.Price)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ProcessDate)
                .HasComment("วันที่ดำเนินการ")
                .HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasComment("รหัสอ้างอิง Id ของตารางที่ระบุ");
            entity.Property(e => e.ReferenceTable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อตารางที่อ้างอิง");
            entity.Property(e => e.SourceMaterialStockId).HasComment("รายการวัสดุคงคลังต้นทาง อ้างอิง MaterialStock.Id");
            entity.Property(e => e.SourceWareHouseId).HasComment("คลังต้นทาง อ้างอิง MasterWarehouse.Id");
            entity.Property(e => e.TargetMaterialStockId).HasComment("รายการวัสดุคงคลังปลายทาง อ้างอิง MaterialStock.Id");
            entity.Property(e => e.TargetWareHouseId).HasComment("คลังปลายทาง อ้างอิง MasterWarehouse.Id");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ธุรกรรม I = In, O = Out");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Officer>(entity =>
        {
            entity.ToTable("Officer", tb => tb.HasComment("เจ้าหน้าที่"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Address)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("ที่อยู่");
            entity.Property(e => e.AdorganizeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงาน ใน Active Directory")
                .HasColumnName("ADOrganizeName");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขที่บัญชีธนาคาร");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("สาขาของบัญชีธนาคาร");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("ธนาคารเจ้าของบัญชี อ้างอิง MasterBank.Id");
            entity.Property(e => e.BirthDate)
                .HasComment("วันเกิด")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditCardExpireMonth).HasComment("เดือนที่บัตรเครดิตราชการหมดอายุ");
            entity.Property(e => e.CreditCardExpireYear).HasComment("เดือนที่บัตรเครดิตราชการหมดอายุ");
            entity.Property(e => e.CreditCardNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขที่บัตรเครดิตราชการ");
            entity.Property(e => e.DistinguishedName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Distinguished Name ใน Active Directory");
            entity.Property(e => e.DivisionId).HasComment("รหัสส่วนงาน อ้างอิง Organization.Id ");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่ใบอนุญาตขับขี่");
            entity.Property(e => e.EndWorkDate)
                .HasComment("วันที่สิ้นสุดการทำงาน")
                .HasColumnType("datetime");
            entity.Property(e => e.ExecutivePositionId).HasComment("รหัสอ้างอิงตำแหน่งบริหาร อ้างอิง MasterPosition.Id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ");
            entity.Property(e => e.FirstNameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อภาษาไทย");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("นามสกุล");
            entity.Property(e => e.LastNameThai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("นามสกุลภาษาไทย");
            entity.Property(e => e.LastSync)
                .HasComment("วันที่ sync จาก Active Directory ล่าสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.NamePrefixId).HasComment("รหัสอ้างอิงคำนำหน้าชื่อ อ้างอิง MasterNamePrefix.Id");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("objectid ของ Active Directory");
            entity.Property(e => e.OrganizationId).HasComment("รหัสอ้างอิงหน่วยงานที่ใช้ในระบบ อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.PersonalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("หมายเลขบัตรประชาชน");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขโทรศัพท์");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("คำอธิบาย");
            entity.Property(e => e.StartWorkDate)
                .HasComment("วันที่เริ่มต้นการทำงาน")
                .HasColumnType("datetime");
            entity.Property(e => e.SystemUserId).HasComment("รหัสอ้างอิงผู้ใช้งานในระบบ อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkPositionId).HasComment("รหัสอ้างอิงตำแหน่งทางสายงาน อ้างอิง MasterPosition.Id");
        });

        modelBuilder.Entity<Procurement>(entity =>
        {
            entity.ToTable("Procurement", tb => tb.HasComment("โครงการจัดซื้อ/จัดจ้าง"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.ContractDate)
                .HasComment("วันที่สัญญา/ใบสั่งซื้อ")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasComment("ชื่องาน/โครงการที่จัดซื้อจัดจ้าง");
            entity.Property(e => e.ProcurementEndDate)
                .HasComment("วันที่สิ้นสุดสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.ProcurementMethodId).HasComment("วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id");
            entity.Property(e => e.ProcurementStartDate)
                .HasComment("วันที่เริ่มต้นสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.SupplierId).HasComment("ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ขาย/ผู้รับจ้าง/ผู้บริจาค");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project", tb => tb.HasComment("งาน/โครงการ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Achievement)
                .IsUnicode(false)
                .HasComment("ผลงานในปีที่ผ่านมา");
            entity.Property(e => e.BudgetGovernmentId).HasComment("รายการเงินงบประมาณแผ่นดิน อ้างอิง BudgetGovernment.Id");
            entity.Property(e => e.BudgetRequestId).HasComment("คำของบประมาณ อ้างอิง BudgetRequest.Id");
            entity.Property(e => e.BudgetTypeId).HasComment("ประเภทงบ อ้างอิง MasterBudgetType.Id");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณ");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่อ้างอิง");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpectedStartDate)
                .HasComment("วันที่คาดว่าจะเริ่มต้น")
                .HasColumnType("datetime");
            entity.Property(e => e.FundId).HasComment("กองทุน อ้างอิง MasterFund.Id");
            entity.Property(e => e.IsManageByHq)
                .HasComment("สพจ.ดำเนินการเอง โดยผ่านส่วนกลางบริหารโครงการ (True=ใช่, False=ไม่ใช่)")
                .HasColumnName("IsManageByHQ");
            entity.Property(e => e.IsUseBudget).HasComment("ใช้งบประมาณ (True=ใช้งบประมาณ, False=ไม่ใช้งบประมาณ)");
            entity.Property(e => e.ManageOrganizationId).HasComment("หน่วยงานบริหารโครงการ อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.Objective)
                .IsUnicode(false)
                .HasComment("วัตถุประสงค์");
            entity.Property(e => e.OperationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("รูปแบบโครงการ (S=ดำเนินการเอง, P=จ้างที่ปรึกษา)");
            entity.Property(e => e.OrganizationId).HasComment("หน่วยงาน อ้างอิง MasterOrganization.Id ");
            entity.Property(e => e.ProcurementMethodId).HasComment("วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id");
            entity.Property(e => e.ProcurementPlanRemark)
                .IsUnicode(false)
                .HasComment("หมายเหตุแผนการจัดซื้อจัดจ้าง");
            entity.Property(e => e.ProjectKpi)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัด")
                .HasColumnName("ProjectKPI");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("ชื่องาน/โครงการ");
            entity.Property(e => e.ProjectOutcome)
                .IsUnicode(false)
                .HasComment("ผลลัพธ์ของโครงการ");
            entity.Property(e => e.ProjectOutput)
                .IsUnicode(false)
                .HasComment("ผลผลิตของโครงการ");
            entity.Property(e => e.ProjectPlace)
                .IsUnicode(false)
                .HasComment("สถานที่ดำเนินงาน");
            entity.Property(e => e.ProjectTarget)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.Reason)
                .IsUnicode(false)
                .HasComment("หลักการและเหตุผล");
            entity.Property(e => e.Running).HasComment("เลข Running สำหรับเรียงลำดับ");
            entity.Property(e => e.TimeFrame).HasComment("ระยะเวลาดำเนินการ (เดือน)");
            entity.Property(e => e.TotalAllocateAmount)
                .HasComment("รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalRequestAmount)
                .HasComment("รวมเงินคำของบประมาณ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectActivityPlanItem>(entity =>
        {
            entity.ToTable("ProjectActivityPlanItem", tb => tb.HasComment("รายละเอียดระยะเวลาดำเนินโครงการและแผนปฏิบัติ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ActivityName)
                .IsUnicode(false)
                .HasComment("รายการกิจกรรม");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate)
                .HasComment("อัตราที่ตั้ง (ราคาต่อหน่วย)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.Quantity).HasComment("หน่วยนับ (จำนวนคน)");
            entity.Property(e => e.QuantityUnit).HasComment("จำนวนหน่วย");
            entity.Property(e => e.QuantityUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.RelatedOrganization)
                .IsUnicode(false)
                .HasComment("หน่วยงานที่เกี่ยวข้อง");
            entity.Property(e => e.Remark)
                .IsUnicode(false)
                .HasComment("คำอธิบายเพิ่มเติม/หมายเหตุ");
            entity.Property(e => e.RequestAmount)
                .HasComment("คำของบประมาณ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.Responsibility)
                .IsUnicode(false)
                .HasComment("หน้าที่รับผิดชอบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectActivityPlanItemPeriod>(entity =>
        {
            entity.ToTable("ProjectActivityPlanItemPeriod", tb => tb.HasComment("ระยะเวลาดำเนินโครงการ "));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");
            entity.Property(e => e.ProjectActivityPlanItemId).HasComment("รายละเอียดระยะเวลาดำเนินโครงการและแผนปฏิบัติ อ้างอิง ProjectActivityPlanItem.Id");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.StartDate).HasComment("วันที่ที่เริ่มต้น");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectAsset>(entity =>
        {
            entity.ToTable("ProjectAsset", tb => tb.HasComment("หมวดหมู่ครุภัณฑ์ในงาน/โครงการ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetClassId).HasComment("หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id");
            entity.Property(e => e.AssetTypeId).HasComment("หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectAssetItem>(entity =>
        {
            entity.ToTable("ProjectAssetItem", tb => tb.HasComment("รายการครุภัณฑ์ในงาน/โครงการ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อรายการ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IsReplace).HasComment("ครุภัณฑ์ทดแทน (True=เป็น, False=ไม่เป็น)");
            entity.Property(e => e.IsUseStandardPrice).HasComment("ใช้ราคากลาง (True=ใช้ราคากลาง, False=ไม่ใช้ราคากลาง)");
            entity.Property(e => e.ProjectAssetId).HasComment("หมวดหมู่ครุภัณฑ์ในโครงการ อ้างอิง ProjectAsset.Id");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.QuantityUnit).HasComment("จำนวนหน่วย");
            entity.Property(e => e.StandardPriceId).HasComment("ราคากลาง อ้างอิง MasterStandardPrice.Id");
            entity.Property(e => e.TotalAmount)
                .HasComment("รวมเป็นเงินทั้งสิ้น (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id");
            entity.Property(e => e.UnitPrice)
                .HasComment("ราคาต่อหน่วย")
                .HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectConcessionFund>(entity =>
        {
            entity.ToTable("ProjectConcessionFund", tb => tb.HasComment("งาน/โครงการกองทุนสัมปทาน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AlternateEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("อีเมลผู้รับผิดชอบสำรอง");
            entity.Property(e => e.AlternateOfficerId).HasComment("ชื่อผู้รับผิดชอบโครงการสำรอง อ้างอิง Officer.Id");
            entity.Property(e => e.AlternateOrganizationId).HasComment("หน่วยงานผู้รับผิดชอบสำรอง อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.AlternatePhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เบอร์โทรผู้รับผิดชอบสำรอง");
            entity.Property(e => e.ConsistencyId).HasComment("ความสอดคล้องกับวัตถุประสงค์ของกองทุน อ้างอิง MasterCompliance.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpectedResults)
                .IsUnicode(false)
                .HasComment("ผลที่คาดว่าจะได้รับ");
            entity.Property(e => e.MainEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("อีเมลผู้รับผิดชอบหลัก");
            entity.Property(e => e.MainOfficerId).HasComment("ชื่อผู้รับผิดชอบโครงการหลัก อ้างอิง Officer.Id");
            entity.Property(e => e.MainOrganizationId).HasComment("หน่วยงานผู้รับผิดชอบหลัก อ้างอิง MasterOrganization.Id");
            entity.Property(e => e.MainPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เบอร์โทรผู้รับผิดชอบหลัก");
            entity.Property(e => e.PlanConsistency)
                .IsUnicode(false)
                .HasComment("ความสอดคล้องตามแผนหรือนโยบายของกระทรวงพลังงาน");
            entity.Property(e => e.Proceed)
                .IsUnicode(false)
                .HasComment("วิธีดำเนินการ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectConservationFund>(entity =>
        {
            entity.ToTable("ProjectConservationFund", tb => tb.HasComment("งาน/โครงการกองทุนอนุรักษ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Benefits)
                .IsUnicode(false)
                .HasComment("ผลประโยชน์ที่คาดว่าจะได้รับจากการดำเนินโครงการ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.HistoryCurrent)
                .IsUnicode(false)
                .HasComment("ความเป็นมาของปัญหาที่เกิดขึ้นในปัจจุบัน");
            entity.Property(e => e.OperationProcess)
                .IsUnicode(false)
                .HasComment("ขั้นตอน/กระบวนการดำเนินงาน");
            entity.Property(e => e.PastOperation)
                .IsUnicode(false)
                .HasComment("การดำเนินงานที่ผ่านมา");
            entity.Property(e => e.Preface)
                .IsUnicode(false)
                .HasComment("บทนำ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.ProjectKpiquality)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัดเชิงคุณภาพ")
                .HasColumnName("ProjectKPIQuality");
            entity.Property(e => e.ProjectKpiquantity)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัดเชิงปริมาณ")
                .HasColumnName("ProjectKPIQuantity");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkGroup)
                .IsUnicode(false)
                .HasComment("กลุ่มงาน");
            entity.Property(e => e.WorkPlan)
                .IsUnicode(false)
                .HasComment("แผน");
        });

        modelBuilder.Entity<ProjectExpensesItem>(entity =>
        {
            entity.ToTable("ProjectExpensesItem", tb => tb.HasComment("รายละเอียดค่าใช้จ่าย งาน/โครงการกองอนุรักษ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate)
                .HasComment("อัตราที่ตั้ง (ราคาต่อหน่วย)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("รายละเอียดค่าใช้จ่าย");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.Quantity).HasComment("หน่วยนับ (จำนวนคน)");
            entity.Property(e => e.QuantityUnit).HasComment("จำนวนหน่วย");
            entity.Property(e => e.QuantityUnitId).HasComment("หน่วยนับ อ้างอิง MasterUnit.Id ");
            entity.Property(e => e.TotalAmount)
                .HasComment("รวมจำนวนเงิน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectProcurementPlanItem>(entity =>
        {
            entity.ToTable("ProjectProcurementPlanItem", tb => tb.HasComment("รายละเอียดแผนการจัดซื้อจัดจ้าง"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.BudgetYear).HasComment("ปีงบประมาณที่ดำเนินการ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Month).HasComment("เดือนที่ดำเนินการ (1=มกราคม, ..., 12=ธันวาคม)");
            entity.Property(e => e.ProcurementMethodId).HasComment("วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id");
            entity.Property(e => e.ProcurementMethodStepId).HasComment("ขั้นตอนการจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethodStep.Id");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.Year).HasComment("ปีปฏิทินที่ดำเนินการ");
        });

        modelBuilder.Entity<ProjectProgressPlanItem>(entity =>
        {
            entity.ToTable("ProjectProgressPlanItem", tb => tb.HasComment("การรายงานความก้าวหน้า งาน/โครงการกองทุนนรักษ์"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Deadline)
                .HasComment("กำหนดเวลาส่ง")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliveredWork)
                .IsUnicode(false)
                .HasComment("งานที่ส่งมอบ");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.ReportDetail)
                .IsUnicode(false)
                .HasComment("การรายงาน");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectProvince>(entity =>
        {
            entity.ToTable("ProjectProvince", tb => tb.HasComment("งาน/โครงการจังหวัด"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Development)
                .IsUnicode(false)
                .HasComment("แนวทางการพัฒนา");
            entity.Property(e => e.MainActivity)
                .IsUnicode(false)
                .HasComment("กิจกรรมหลัก");
            entity.Property(e => e.PlanName)
                .IsUnicode(false)
                .HasComment("ชื่อแผนงาน");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.ProjectKpiquality)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัดเชิงคุณภาพ")
                .HasColumnName("ProjectKPIQuality");
            entity.Property(e => e.ProjectKpiquantity)
                .IsUnicode(false)
                .HasComment("ตัวชี้วัดเชิงปริมาณ")
                .HasColumnName("ProjectKPIQuantity");
            entity.Property(e => e.ProvinceGroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภท กลุ่มจังหวัด = G  จังหวัด = P");
            entity.Property(e => e.TargetArea)
                .IsUnicode(false)
                .HasComment("พื้นที่เป้าหมาย");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectSupplier>(entity =>
        {
            entity.ToTable("ProjectSupplier", tb => tb.HasComment("ผู้เสนอราคาในงาน/โครงการ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.SupplierId).HasComment("ผู้เสนอราคา อ้างอิง Supplier.Id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้เสนอราคา");
            entity.Property(e => e.TotalAmount)
                .HasComment("จำนวนเงิน (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectSupplierItem>(entity =>
        {
            entity.ToTable("ProjectSupplierItem", tb => tb.HasComment("ราคาที่เสนอในงาน/โครงการ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ProjectAssetItemId).HasComment("รายการครุภัณฑ์ในงาน/โครงการ อ้างอิง ProjectAssetItem.Id");
            entity.Property(e => e.ProjectId).HasComment("งาน/โครงการ อ้างอิง Project.Id ");
            entity.Property(e => e.ProjectSupplierId).HasComment("ผู้เสนอราคาในงาน/โครงการ อ้างอิง ProjectSupplier.Id");
            entity.Property(e => e.TotalAmount)
                .HasComment("ราคาที่เสนอ (บาท)")
                .HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier", tb => tb.HasComment("ผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง/ผู้บริจาค"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AccountName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อบัญชีธนาคาร");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ที่อยู่");
            entity.Property(e => e.AmphurId).HasComment("อำเภอ อ้างอิง MasterAmphur.Id");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขบัญชีธนาคาร");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("สาขาธนาคาร");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("ธนาคาร อ้างอิง MasterBank.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("อีเมล์");
            entity.Property(e => e.FullAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ที่อยู่ รูปแบบเต็ม");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง/ผู้บริจาค");
            entity.Property(e => e.PersonType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทบุคคล (P=บุคคลธรรมดา, C=นิติบุคคล)");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขโทรศัพท์");
            entity.Property(e => e.ProvinceId).HasComment("จังหวัด อ้างอิง MasterProvice.Id");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขหลักของผู้ขาย");
            entity.Property(e => e.TambonId).HasComment("ตำบล อ้างอิง MasterTambon.Id");
            entity.Property(e => e.TaxId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasComment("เลขประจำตัวผู้เสียภาษี");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสไปรษณีย์");
        });

        modelBuilder.Entity<SystemConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigName);

            entity.ToTable("SystemConfig", tb => tb.HasComment("การกำหนดค่าของระบบ"));

            entity.Property(e => e.ConfigName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConfigStringValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemMenu>(entity =>
        {
            entity.ToTable("SystemMenu", tb => tb.HasComment("เมนูในระบบ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ Action ของเมนู");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.ControllerMainName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ Controller ของ Parent");
            entity.Property(e => e.ControllerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ Controller ของเมนู");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.IconCss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รูป Icon ที่แสดงในเมนู");
            entity.Property(e => e.IsParent).HasComment("มีเมนูในสังกัดหรือไม่ (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.IsShowInSiteMenu).HasComment("แสดงในเมนูฝั่งซ้าย (True=แสดง, False=ไม่แสดง)");
            entity.Property(e => e.MenuDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("คำอธิบายเมนู");
            entity.Property(e => e.MenuName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อเมนู");
            entity.Property(e => e.ParentMenuId).HasComment("รหัสอ้างอิงเมนูในระบบที่ไปสังกัด อ้างอิง SystemMenu.Id");
            entity.Property(e => e.Sequence).HasComment("การเรียงลำดับ");
            entity.Property(e => e.SystemMenuGroupId).HasComment("ระบบสำหรับการแสดงเมนู อ้างอิง SystemMenuGroup.Id");
            entity.Property(e => e.SystemNameId).HasComment("ชื่อระบบ อ้างอิง SystemName.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("URL ของหน้าจอที่ผูกกับเมนู");
        });

        modelBuilder.Entity<SystemMenuGroup>(entity =>
        {
            entity.ToTable("SystemMenuGroup", tb => tb.HasComment("ระบบสำหรับการแสดงเมนู"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อระบบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.UserManage).HasComment("ใช้ในการจัดการผู้ใช้ (True=ใช้, False=ไม่ใช้)");
        });

        modelBuilder.Entity<SystemMenuRoleAssign>(entity =>
        {
            entity.HasKey(e => new { e.SystemRoleId, e.SystemMenuId });

            entity.ToTable("SystemMenuRoleAssign", tb => tb.HasComment("การกำหนดสิทธิการใช้เมนู"));

            entity.Property(e => e.SystemRoleId).HasComment("ระดับการเข้าใช้งานในระบบ อ้างอิง SystemRole.Id");
            entity.Property(e => e.SystemMenuId).HasComment("เมนูในระบบ อ้างอิง SystemMenu.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemNotification>(entity =>
        {
            entity.ToTable("SystemNotification", tb => tb.HasComment("การแจ้งเตือน"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.NotificationDate)
                .HasComment("วันที่แจ้งเตือน")
                .HasColumnType("datetime");
            entity.Property(e => e.NotificationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทการแจ้งเตือน (U=แจ้งถึงผู้ใช้คนเดียว, R=แจ้งถึงทุกคนใน role, O=แจ้งถึงทุกคนในหน่วยงานเดียวกัน)");
            entity.Property(e => e.OpenDate)
                .HasComment("วันที่เปิดดูการแจ้งเตือน")
                .HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasComment("รหัสที่อ้างอิง");
            entity.Property(e => e.ReferenceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ประเภทอ้างอิง");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasComment("สถานะ (N=new, O=open, V=void)");
            entity.Property(e => e.SystemUserId).HasComment("ผู้ใช้งานที่ได้รับการแจ้งเตือน อ้างอิง SystemUser.Id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("หัวข้อ/เรื่อง");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemRole>(entity =>
        {
            entity.ToTable("SystemRole", tb => tb.HasComment("ระดับการเข้าใช้งานในระบบ"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("คำอธิบาย");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อระดับการเข้าใช้งานในระบบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemUser>(entity =>
        {
            entity.ToTable("SystemUser", tb => tb.HasComment("ผู้ใช้งานระบบ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("อีเมล");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ");
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("IP Address ล่าสุดที่ใช้")
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastLogin)
                .HasComment("วันที่ล่าสุดที่ Login")
                .HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("นามสกุล");
            entity.Property(e => e.LoginType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทผู้ใช้ (A=AD, S=System)");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รหัสผ่านใช้ในการเข้าใช้งานระบบ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อใช้ในการเข้าใช้งานระบบ");
        });

        modelBuilder.Entity<SystemUserRoleAssign>(entity =>
        {
            entity.ToTable("SystemUserRoleAssign", tb => tb.HasComment("กำหนดสิทธิสำหรับผู้ใช้งานระบบ"));

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.Active).HasComment("สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate)
                .HasComment("วันที่มีผล")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpireDate)
                .HasComment("วันที่สิ้นสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActing).HasComment("เป็นการรักษาการแทน (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.Priority).HasComment("ลำดับความสำคัญ");
            entity.Property(e => e.SystemMenuGroupId).HasComment("ระบบ อ้างอิง SystemMenuGroup.Id");
            entity.Property(e => e.SystemRoleId).HasComment("ระดับการเข้าใช้งานในระบบ อ้างอิง SystemRole.Id");
            entity.Property(e => e.SystemUserId).HasComment("ผู้ใช้งานในระบบ อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheck");

            entity.Property(e => e.AnnualCheckFromDate).HasColumnType("datetime");
            entity.Property(e => e.AnnualCheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnnualCheckStatusName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AnnualCheckToDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheckAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckAsset");

            entity.Property(e => e.AssetCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.NewOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NewStorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NewStorePlaceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OldOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OldStorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OldStorePlaceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheckAssetReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckAssetReport");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.AssetCategory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Available)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturnReasonDetail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StorePlaceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Usable)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAnnualCheckCommittee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckCommittee");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.CommitteePosition)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CommitteePositionName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OfficerName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheckMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckMaterial");

            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheckOrganization>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckOrganization");

            entity.Property(e => e.AnnualCheckFromDate).HasColumnType("datetime");
            entity.Property(e => e.AnnualCheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnnualCheckStatusName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AnnualCheckToDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAnnualCheckOrganizationReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AnnualCheckOrganizationReport");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Asset");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.AssetAcquisitionTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssetBudgetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssetCategory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetClassCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AssetClassName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetDetail).IsUnicode(false);
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.AssetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetStatusName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BuildingName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ChassisNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodeOld)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CostCenterName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Depreciation).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTypeName)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EngineNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FuelTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsAssetNumberGfmis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IsAssetNumberGFMIS");
            entity.Property(e => e.IsExpire)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.IsInMa).HasColumnName("IsInMA");
            entity.Property(e => e.LandTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementEndDate).HasColumnType("datetime");
            entity.Property(e => e.ProcurementName).IsUnicode(false);
            entity.Property(e => e.ProcurementStartDate).HasColumnType("datetime");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Qrcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("QRCode");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RfidtagNumber).HasColumnName("RFIDTagNumber");
            entity.Property(e => e.ScrapValue).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SetName).IsUnicode(false);
            entity.Property(e => e.Spec).IsUnicode(false);
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StorePlaceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SupplierFullAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SupplierPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WarrantyEndDate).HasColumnType("datetime");
            entity.Property(e => e.WarrantyPeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WarrantyStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetBorrow>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetBorrow");

            entity.Property(e => e.AssetBorrowType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetBorrowTypeName)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.BorrowApproveDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowDocument)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowFromDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowerDivisionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerOfficerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BorrowerPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerPositionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IsReturn)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LendApproveDate).HasColumnType("datetime");
            entity.Property(e => e.LendApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LendDate).HasColumnType("datetime");
            entity.Property(e => e.LenderOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPositionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetBorrowItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetBorrowItem");

            entity.Property(e => e.AssetBorrowStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetBorrowStatusName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BorrowDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetBorrowReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetBorrowReport");

            entity.Property(e => e.ApproveStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AssetBorrowType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetBorrowTypeName)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.BorrowApproveDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowDocument)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowFromDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowerDivisionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerOfficerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BorrowerPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerPositionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BorrowerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IsReturn)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LendApproveDate).HasColumnType("datetime");
            entity.Property(e => e.LendApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LendApprovePositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LendDate).HasColumnType("datetime");
            entity.Property(e => e.LenderOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NotApproveDetail)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OtherEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherPhoneExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPositionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetChange>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetChange");

            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeDetail).IsUnicode(false);
            entity.Property(e => e.ChangeTypeName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceTable)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.ResponsibleOfficerName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetMaintenance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetMaintenance");

            entity.Property(e => e.AccountingDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MaintenanceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetMaintenanceForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetMaintenanceForm");

            entity.Property(e => e.CheckOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.ExpectDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturnCompleteDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetMaintenanceFormItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetMaintenanceFormItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.CheckDatail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.MaintenanceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetRelation");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetRequisition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetRequisition");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DeliverDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.ExpectDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequestOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetRequisitionItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetRequisitionItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetReturn");

            entity.Property(e => e.AcceptDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetReturnType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckDate).HasColumnType("datetime");
            entity.Property(e => e.CheckOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetReturnItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetReturnItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.CheckDatail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ReturnDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.Usable)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAssetTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetTransfer");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DestinationOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TransferOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TransferOrganizationName)
                .HasMaxLength(253)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetTransferItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetTransferItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.NewAssetCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NewAssetNumberGFMIS");
            entity.Property(e => e.NewReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.OldAssetCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OldAssetNumberGFMIS");
            entity.Property(e => e.OldReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.TransferDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetTransferReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetTransferReport");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.NewAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NewAssetNumberGFMIS");
            entity.Property(e => e.NewReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.OldAssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OldAssetNumberGFMIS");
            entity.Property(e => e.OldReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveAreaCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveCostCenterCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveOrganizationCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveOrganizationName)
                .HasMaxLength(253)
                .IsUnicode(false);
            entity.Property(e => e.ReceivePositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransferAreaCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransferCostCenterCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TransferOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TransferOrganizationCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TransferOrganizationName)
                .HasMaxLength(253)
                .IsUnicode(false);
            entity.Property(e => e.TransferPositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetWaitingSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetWaitingSale");

            entity.Property(e => e.AssetClassName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssetCodeOld)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.AssetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AssetStatusName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeGroup)
                .HasMaxLength(223)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Cause)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CommentCommittee)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CostCenterName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrentCost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StorePlaceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usable)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAssetWriteOff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetWriteOff");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ReferenceDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceDocument)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WriteOffDate).HasColumnType("datetime");
            entity.Property(e => e.WriteOffDetail).IsUnicode(false);
            entity.Property(e => e.WriteOffStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WriteOffStatusName)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.WriteOffType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WriteOffTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAssetWriteOffItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetWriteOffItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.UnusableDetail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VAssetWriteOffReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_AssetWriteOffReport");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssetNumberGfmis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AssetNumberGFMIS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.CostCenterCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DestinationCostCenterCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DestinationOrganizationCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DestinationOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WriteOffDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetAllocateList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetAllocateList");

            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalBalanceAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalObligationAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalPaymentAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalTransferAmount).HasColumnType("numeric(38, 2)");
        });

        modelBuilder.Entity<VBudgetDisbursementPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetDisbursementPlan");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetDisbursementPlanItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetDisbursementPlanItem");

            entity.Property(e => e.AllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.Condition).IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DisbursementDetail).IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlanAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetDisbursementPlanItemPivot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetDisbursementPlanItemPivot");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalPlanAmount)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e._1)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("1");
            entity.Property(e => e._10)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("10");
            entity.Property(e => e._11)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("11");
            entity.Property(e => e._12)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("12");
            entity.Property(e => e._2)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("2");
            entity.Property(e => e._3)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("3");
            entity.Property(e => e._4)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("4");
            entity.Property(e => e._5)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("5");
            entity.Property(e => e._6)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("6");
            entity.Property(e => e._7)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("7");
            entity.Property(e => e._8)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("8");
            entity.Property(e => e._9)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("9");
        });

        modelBuilder.Entity<VBudgetGovernment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetGovernment");

            entity.Property(e => e.ActivityCodeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BudgetExpenseTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BudgetFormTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BudgetGovernmentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BudgetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RefundAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalAllocateAmountCentral).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalAllocateAmountProvince).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetGovernmentItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetGovernmentItem");

            entity.Property(e => e.ActivityCodeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BudgetExpenseTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BudgetFormTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BudgetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.QuantityUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetReceive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetReceive");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BudgetExpenseTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BudgetRequest");

            entity.Property(e => e.BudgetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalBalanceAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalObligationAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalPaymentAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalTransferAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterActivityCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterActivityCode");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OutputCodeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategicName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategicPlanName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Target).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterAssetClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterAssetClass");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterAssetType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterAssetType");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Depreciation).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterBudgetExpenseType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterBudgetExpenseType");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MoneySourceName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OutputCodeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategicName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategicPlanName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterMaterial");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSCCode");
            entity.Property(e => e.MaterialDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MaterialGroupName)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterMaterialGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterMaterialGroup");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.NameThai)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterOutputCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterOutputCode");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OutputType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OutputTypeName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.StrategicName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategicPlanName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Target).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterStandardPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterStandardPrice");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterStorePlace>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterStorePlace");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StorePlaceDetail)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterStrategicPlanCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterStrategicPlanCode");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StrategyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Target).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterStrategyCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterStrategyCode");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveToDate).HasColumnType("datetime");
            entity.Property(e => e.Kpi)
                .IsUnicode(false)
                .HasColumnName("KPI");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Target).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterUnit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterUnit");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Egpactive).HasColumnName("EGPActive");
            entity.Property(e => e.Egpid).HasColumnName("EGPID");
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMasterWarehouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MasterWarehouse");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WarehouseLevelName)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMaterialBorrow>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialBorrow");

            entity.Property(e => e.ApproveByName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowerByName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SourceOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusApprove)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TargetOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMaterialBorrowItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialBorrowItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReturnByName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReturneeByName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMaterialIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialIn");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ProcurementNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalValue).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VMaterialInItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialInItem");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GPSCCode");
            entity.Property(e => e.IncludeVat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IncludeVAT");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalValue).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPriceNoVat).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WarehouseLevelName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMaterialRequisition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialRequisition");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverApproveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DeliverApproveOfficerPositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeliverDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DeliverOfficerPositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiveOfficerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveOfficerPositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RequestByName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.RequestByPositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusApprove)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMaterialRequisitionItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialRequisitionItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GPSCCode");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMaterialSafetyStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialSafetyStock");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VMaterialStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MaterialStock");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Gpsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSCCode");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPriceNoVat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.WarehouseLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VMonthList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MonthList");

            entity.Property(e => e.MonthEn)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("MonthEN");
            entity.Property(e => e.MonthTh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MonthTH");
        });

        modelBuilder.Entity<VOfficer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Officer");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.AdorganizeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADOrganizeName");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.CreditCardNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DistinguishedName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EndWorkDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastSync).HasColumnType("datetime");
            entity.Property(e => e.NamePrefix)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(253)
                .IsUnicode(false);
            entity.Property(e => e.PersonalId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PositionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.StartWorkDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProcurement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Procurement");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContractDate).HasColumnType("datetime");
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ProcurementEndDate).HasColumnType("datetime");
            entity.Property(e => e.ProcurementStartDate).HasColumnType("datetime");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Project");

            entity.Property(e => e.Achievement).IsUnicode(false);
            entity.Property(e => e.BudgetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.FundName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsManageByHq).HasColumnName("IsManageByHQ");
            entity.Property(e => e.ManageOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Objective).IsUnicode(false);
            entity.Property(e => e.OperationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OperationTypeName)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementMethodName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementPlanRemark).IsUnicode(false);
            entity.Property(e => e.ProjectKpi)
                .IsUnicode(false)
                .HasColumnName("ProjectKPI");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ProjectOutcome).IsUnicode(false);
            entity.Property(e => e.ProjectOutput).IsUnicode(false);
            entity.Property(e => e.ProjectPlace).IsUnicode(false);
            entity.Property(e => e.ProjectTarget).IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectActivityPlanItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectActivityPlanItem");

            entity.Property(e => e.ActivityName).IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.QuantityUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RelatedOrganization).IsUnicode(false);
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.RequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.Responsibility).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectActivityPlanItemPeriod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectActivityPlanItemPeriod");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectAsset");

            entity.Property(e => e.AssetClassName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ProcurementPlanRemark).IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TotalReceiveAmount).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectAssetItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectAssetItem");

            entity.Property(e => e.AssetName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectExpensesItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectExpensesItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.ExpenseRate).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.ExpenseRateUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.QuantityUnitName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectProcurementPlanItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectProcurementPlanItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementMethodName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementMethodStepName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcurementPlanRemark).IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TotalAllocateAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectProgressPlanItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectProgressPlanItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Deadline).HasColumnType("datetime");
            entity.Property(e => e.DeliveredWork).IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ReportDetail).IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectProvince>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectProvince");

            entity.Property(e => e.BudgetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Development).IsUnicode(false);
            entity.Property(e => e.MainActivity).IsUnicode(false);
            entity.Property(e => e.Objective).IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PlanName).IsUnicode(false);
            entity.Property(e => e.ProjectKpiquality)
                .IsUnicode(false)
                .HasColumnName("ProjectKPIQuality");
            entity.Property(e => e.ProjectKpiquantity)
                .IsUnicode(false)
                .HasColumnName("ProjectKPIQuantity");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ProjectOutcome).IsUnicode(false);
            entity.Property(e => e.ProjectOutput).IsUnicode(false);
            entity.Property(e => e.ProvinceGroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProvinceGroupName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TargetArea).IsUnicode(false);
            entity.Property(e => e.TotalRequestAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectSupplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectSupplier");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VProjectSupplierItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ProjectSupplierItem");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VSupplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Supplier");

            entity.Property(e => e.ActiveName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FullAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameThai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PersonType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxId)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSystemUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SystemUser");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSystemUserRoleAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SystemUserRoleAssign");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SystemUserRoleId).HasColumnName("SystemUserRoleID");
        });

        modelBuilder.Entity<ZLFlow>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Version });

            entity.ToTable("zL_Flow");

            entity.Property(e => e.Version).HasMaxLength(10);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.ExpireTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZLJob>(entity =>
        {
            entity.HasKey(e => e.JobId);

            entity.ToTable("zL_Job");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.JsonData).IsUnicode(false);
            entity.Property(e => e.JsonElementId)
                .HasComment("ข้อมูลJson Properties")
                .HasColumnType("text");
            entity.Property(e => e.NextProcessCode).HasMaxLength(255);
            entity.Property(e => e.ParameterBit1).HasColumnName("Parameter_Bit1");
            entity.Property(e => e.ParameterBit2).HasColumnName("Parameter_Bit2");
            entity.Property(e => e.ParameterBit3).HasColumnName("Parameter_Bit3");
            entity.Property(e => e.ParameterDecimal1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal1");
            entity.Property(e => e.ParameterDecimal2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal2");
            entity.Property(e => e.ParameterDecimal3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal3");
            entity.Property(e => e.ParameterInt1).HasColumnName("Parameter_Int1");
            entity.Property(e => e.ParameterInt2).HasColumnName("Parameter_Int2");
            entity.Property(e => e.ParameterInt3).HasColumnName("Parameter_Int3");
            entity.Property(e => e.ParameterString1)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String1");
            entity.Property(e => e.ParameterString2)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String2");
            entity.Property(e => e.ParameterString3)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String3");
            entity.Property(e => e.PreviuosProcessCode).HasMaxLength(255);
            entity.Property(e => e.ProcessCode).HasMaxLength(255);
            entity.Property(e => e.StatusId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.Version).HasMaxLength(10);
        });

        modelBuilder.Entity<ZLJobLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("zL_JobLog");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.JsonData).IsUnicode(false);
            entity.Property(e => e.JsonElementId)
                .HasComment("ข้อมูลJson Properties")
                .HasColumnType("text");
            entity.Property(e => e.NextProcessCode).HasMaxLength(255);
            entity.Property(e => e.ParameterBit1).HasColumnName("Parameter_Bit1");
            entity.Property(e => e.ParameterBit2).HasColumnName("Parameter_Bit2");
            entity.Property(e => e.ParameterBit3).HasColumnName("Parameter_Bit3");
            entity.Property(e => e.ParameterDecimal1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal1");
            entity.Property(e => e.ParameterDecimal2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal2");
            entity.Property(e => e.ParameterDecimal3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Parameter_Decimal3");
            entity.Property(e => e.ParameterInt1).HasColumnName("Parameter_Int1");
            entity.Property(e => e.ParameterInt2).HasColumnName("Parameter_Int2");
            entity.Property(e => e.ParameterInt3).HasColumnName("Parameter_Int3");
            entity.Property(e => e.ParameterString1)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String1");
            entity.Property(e => e.ParameterString2)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String2");
            entity.Property(e => e.ParameterString3)
                .HasMaxLength(512)
                .HasColumnName("Parameter_String3");
            entity.Property(e => e.PreviuosProcessCode).HasMaxLength(255);
            entity.Property(e => e.ProcessCode).HasMaxLength(255);
            entity.Property(e => e.StatusId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.Version).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
