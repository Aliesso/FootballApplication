//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChangingRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChangingRooms()
        {
            this.RezervationToRooms = new HashSet<RezervationToRooms>();
        }
    
        public int CR_ID { get; set; }
        public string Number { get; set; }
        public string Capacity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RezervationToRooms> RezervationToRooms { get; set; }
    }
}
