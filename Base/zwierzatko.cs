//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class zwierzatko
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zwierzatko()
        {
            this.kobietas = new HashSet<kobieta>();
            this.mezczyznas = new HashSet<mezczyzna>();
        }
    
        public byte ID { get; set; }
        public Nullable<byte> Gatunek_ID { get; set; }
        public string Imie { get; set; }
    
        public virtual gatunek gatunek { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kobieta> kobietas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mezczyzna> mezczyznas { get; set; }
    }
}
