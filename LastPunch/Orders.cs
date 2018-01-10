//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LastPunch
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Accountancy = new HashSet<Accountancy>();
        }
    
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int TotalSongs { get; set; }
        public string Tracks { get; set; }
        public Nullable<int> LevelProcessing { get; set; }
        public Nullable<int> LoudnessLevel { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> Finished { get; set; }
        public int CustomerId { get; set; }
        public int EngineerID { get; set; }
        public int CompanyID { get; set; }
        public int FormatID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accountancy> Accountancy { get; set; }
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Engineer Engineer { get; set; }
        public virtual Format Format { get; set; }
    }
}