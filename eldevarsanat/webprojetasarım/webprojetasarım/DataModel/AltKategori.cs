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
    
    public partial class AltKategori
    {
        public int AltKategoriID { get; set; }
        public string AltKategoriAd { get; set; }
        public int KategoriID { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
    }
}
