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
    
    public partial class TBLNOTLAR
    {
        public int NOTID { get; set; }
        public string BASLIK { get; set; }
        public string ICERIK { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.TimeSpan> SAAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
    }
}
