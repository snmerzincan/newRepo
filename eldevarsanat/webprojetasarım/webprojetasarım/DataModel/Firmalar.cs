//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webprojetasarım.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmalar()
        {
            this.Siparisler = new HashSet<Siparisler>();
        }
    
        public int FirmaID { get; set; }
        public string FirmaAd { get; set; }
        public string FirmaTel { get; set; }
        public string FirmaEposta { get; set; }
        public string FirmaAdres { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }
    }
}
