//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_URUNKABUL
    {
        public int ISLEMID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public Nullable<System.DateTime> GELISTARIH { get; set; }
        public Nullable<System.DateTime> CIKISITARIH { get; set; }
        public string URUNSERINO { get; set; }
        public Nullable<bool> URUNDURUM { get; set; }
        public string DURUMDETAY { get; set; }
    
        public virtual TBL_CARI TBL_CARI { get; set; }
        public virtual TBL_PERSONEL TBL_PERSONEL { get; set; }
    }
}
