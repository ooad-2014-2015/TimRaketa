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
    
    public partial class KATALOG_BICIKALA
    {
        public int biciklo_id { get; set; }
        public string naziv_proizvodjaca { get; set; }
        public Nullable<decimal> cijena { get; set; }
        public Nullable<System.DateTime> godina_proizvodnje { get; set; }
        public Nullable<int> tip_bicikla_id { get; set; }
        public string dodatni_opis { get; set; }
    
        public virtual TIPOVI_BICIKALA TIPOVI_BICIKALA { get; set; }
    }
}
