//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testXampp
{
    using System;
    using System.Collections.Generic;
    
    public partial class angajat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public angajat()
        {
            this.operatiunes = new HashSet<operatiune>();
        }
    
        public int id { get; set; }
        public string nume { get; set; }
        public Nullable<System.DateTime> data_angajarii { get; set; }
        public Nullable<int> experienta { get; set; }
    
        public virtual salar salar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operatiune> operatiunes { get; set; }
    }
}
