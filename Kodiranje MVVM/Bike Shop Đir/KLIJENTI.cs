//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bike_Shop_Đir
{
    using System;
    using System.Collections.Generic;
    
    public partial class KLIJENTI
    {
        public KLIJENTI()
        {
            this.KATALOG_TURA = new HashSet<KATALOG_TURA>();
            this.KORPEs = new HashSet<KORPE>();
        }
    
        public int klijent_id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa_stanovanja { get; set; }
        public string username { get; set; }
        public string sifra { get; set; }
        public Nullable<int> broj_kartice { get; set; }
    
        public virtual ICollection<KATALOG_TURA> KATALOG_TURA { get; set; }
        public virtual ICollection<KORPE> KORPEs { get; set; }
    }
}
