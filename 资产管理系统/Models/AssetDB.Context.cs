﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 资产管理系统.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssetDBEntities : DbContext
    {
        public AssetDBEntities()
            : base("name=AssetDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreaInfo> AreaInfo { get; set; }
        public virtual DbSet<AreaTypeInfo> AreaTypeInfo { get; set; }
        public virtual DbSet<AssetDetailInfo> AssetDetailInfo { get; set; }
        public virtual DbSet<AssetDetailRecordInfo> AssetDetailRecordInfo { get; set; }
        public virtual DbSet<AssetInfo> AssetInfo { get; set; }
        public virtual DbSet<AssetPutInfo> AssetPutInfo { get; set; }
        public virtual DbSet<CampusInfo> CampusInfo { get; set; }
        public virtual DbSet<DamageRecordInfo> DamageRecordInfo { get; set; }
        public virtual DbSet<DeptInfo> DeptInfo { get; set; }
        public virtual DbSet<EmpolyInfo> EmpolyInfo { get; set; }
        public virtual DbSet<OfficeSuppliesRecordInfo> OfficeSuppliesRecordInfo { get; set; }
        public virtual DbSet<RoleInfo> RoleInfo { get; set; }
    }
}
