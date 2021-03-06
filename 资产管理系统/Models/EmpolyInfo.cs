//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class EmpolyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpolyInfo()
        {
            this.DamageRecordInfo = new HashSet<DamageRecordInfo>();
        }
    
        public int EmpolyId { get; set; }
        public string EmpolyNum { get; set; }
        public string EmpolyPwd { get; set; }
        public string EmpolyName { get; set; }
        public string EmpolySex { get; set; }
        public string EmpolyIdCard { get; set; }
        public string EmpolyImg { get; set; }
        public int DeptId { get; set; }
        public int EmpolyLevel { get; set; }
        public int RoletId { get; set; }
        public Nullable<System.DateTime> InductionDate { get; set; }
        public Nullable<System.DateTime> DepartureDate { get; set; }
        public string EmpolyReMark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DamageRecordInfo> DamageRecordInfo { get; set; }
        public virtual DeptInfo DeptInfo { get; set; }
        public virtual RoleInfo RoleInfo { get; set; }
    }
}
