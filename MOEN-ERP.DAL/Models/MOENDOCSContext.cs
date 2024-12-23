using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.DAL.Models;

public partial class MOENDOCSContext : DbContext
{
    public MOENDOCSContext()
    {
    }

    public MOENDOCSContext(DbContextOptions<MOENDOCSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssetImage> AssetImages { get; set; }

    public virtual DbSet<AssetTrackImage> AssetTrackImages { get; set; }

    public virtual DbSet<AttachFile> AttachFiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dev.softsuite.co.th;Database=MOENDOCS;User Id=energyerpadmin;Password=!energy2024!;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssetImage>(entity =>
        {
            entity.ToTable("AssetImage", tb => tb.HasComment("รูปครุภัณฑ์"));

            entity.HasIndex(e => e.RowGuid, "UQ__AssetIma__B975DD83E013040C").IsUnique();

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("ครุภัณฑ์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetTrackImageId).HasComment("รูปครุภัณฑ์จากการนับ อ้างอิง AssetTrackImage.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("นามสกุลไฟล์");
            entity.Property(e => e.FileSize).HasComment("ขนาดไฟล์");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไฟล์");
            entity.Property(e => e.ImageData).HasComment("รูป");
            entity.Property(e => e.IsMain).HasComment("เป็นรูปหลักในการแสดงผล (True=ใช่, False=ไม่ใช่)");
            entity.Property(e => e.ReferenceGroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("กลุ่มประเภทรูป (A=รูปครุภัณฑ์, N=รูปหมายเลขครุภัณฑ์, S=รูปสถานที่จัดเก็บ)");
            entity.Property(e => e.RowGuid)
                .HasDefaultValueSql("(newid())")
                .HasComment("RowGuid");
            entity.Property(e => e.Sequence).HasComment("ลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetTrackImage>(entity =>
        {
            entity.ToTable("AssetTrackImage", tb => tb.HasComment("รูปจากการตรวจสอบครุภัณฑ์ประจำปี"));

            entity.HasIndex(e => e.RowGuid, "UQ__AssetTra__B975DD83C1059244").IsUnique();

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.AssetId).HasComment("ครุภัณฑ์ อ้างอิง Asset.Id");
            entity.Property(e => e.AssetTrackId).HasComment("การตรวจสอบครุภัณฑ์ประจำปี อ้างอิง AssetTrack.Id");
            entity.Property(e => e.AssetTrackItemId).HasComment("รายการในการตรวจสอบครุภัณฑ์ประจำปี อ้างอิง AssetTrackItem.Id");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("นามสกุลไฟล์");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไฟล์");
            entity.Property(e => e.ImageData).HasComment("รูป");
            entity.Property(e => e.RowGuid).HasComment("RowGuid");
            entity.Property(e => e.Sequence).HasComment("ลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AttachFile>(entity =>
        {
            entity.ToTable("AttachFile", tb => tb.HasComment("ไฟล์แนบ"));

            entity.HasIndex(e => e.RowGuid, "UQ__AttachFi__B975DD83CAC0021C").IsUnique();

            entity.Property(e => e.Id).HasComment("รหัสอ้างอิงที่ใช้ในระบบ");
            entity.Property(e => e.CreateBy)
                .HasDefaultValueSql("((-1))")
                .HasComment("ผู้สร้าง อ้างอิง SystemUser.Id");
            entity.Property(e => e.CreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("นามสกุลไฟล์");
            entity.Property(e => e.FileData).HasComment("ข้อมูลไฟล์");
            entity.Property(e => e.FileSize).HasComment("ขนาดไฟล์");
            entity.Property(e => e.Filename)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("ชื่อไฟล์");
            entity.Property(e => e.ReferenceGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("กลุ่มประเภทไฟล์");
            entity.Property(e => e.ReferenceId).HasComment("รายการอ้างอิง");
            entity.Property(e => e.ReferenceTable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ตารางอ้างอิง");
            entity.Property(e => e.RowGuid).HasComment("RowGuid");
            entity.Property(e => e.Sequence).HasComment("ลำดับ");
            entity.Property(e => e.UpdateBy).HasComment("ผู้แก้ไข อ้างอิง SystemUser.Id");
            entity.Property(e => e.UpdateOn)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
