//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class edeaccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public edeaccount()
        {
            this.pickuporders = new HashSet<pickuporder>();
        }
    
        public string edeID { get; set; }
        public string customerID { get; set; }
        public string emailAddress { get; set; }
        public string loginAccountName { get; set; }
        public string loginAccountPw { get; set; }
        public string emailNotice { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pickuporder> pickuporders { get; set; }
    }
}