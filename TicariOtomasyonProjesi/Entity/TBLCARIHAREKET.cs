//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicariOtomasyonProjesi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCARIHAREKET
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<short> ADET { get; set; }
        public Nullable<decimal> BIRIMFIYAT { get; set; }
        public Nullable<decimal> TOPLAM { get; set; }
        public string ACIKLAMA { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        public virtual TBLURUN TBLURUN { get; set; }
    }
}
