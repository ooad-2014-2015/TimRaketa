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
    
    public partial class STAVKE_KORPE
    {
        public STAVKE_KORPE()
        {
            this.KORPEs = new HashSet<KORPE>();
        }
    
        public int stavka_id { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<int> tip_usluge_id { get; set; }
        public Nullable<double> cijena { get; set; }
    
        public virtual ICollection<KORPE> KORPEs { get; set; }
        public virtual TIPOVI_USLUGA TIPOVI_USLUGA { get; set; }
    }
}
