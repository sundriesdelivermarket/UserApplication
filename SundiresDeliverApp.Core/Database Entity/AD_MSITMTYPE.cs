//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SundiresDeliverApp.Core.Database_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AD_MSITMTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AD_MSITMTYPE()
        {
            this.AD_MSITMUNIT = new HashSet<AD_MSITMUNIT>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string MachineId { get; set; }
        public string MachineIp { get; set; }
        public System.Guid MS_COMCRE_Id { get; set; }
        public System.Guid AD_MSITMCAT_Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
    
        public virtual AD_MSITMCAT AD_MSITMCAT { get; set; }
        public virtual MS_COMCRE MS_COMCRE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AD_MSITMUNIT> AD_MSITMUNIT { get; set; }
    }
}
