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
    
    public partial class TBL_CARI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CARI()
        {
            this.TBL_FATURABILGI = new HashSet<TBL_FATURABILGI>();
            this.TBL_HAREKET = new HashSet<TBL_HAREKET>();
            this.TBL_URUNKABUL = new HashSet<TBL_URUNKABUL>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYADI { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string BANKA { get; set; }
        public string VERGIDAIRE { get; set; }
        public string VERGINO { get; set; }
        public string STATU { get; set; }
        public string ADRES { get; set; }
        public string ACIKLAMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_FATURABILGI> TBL_FATURABILGI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_HAREKET> TBL_HAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_URUNKABUL> TBL_URUNKABUL { get; set; }
    }
}