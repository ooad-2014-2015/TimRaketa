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
    
    public partial class KATALOG_TURA
    {
        public int tura_id { get; set; }
        public string naziv_ture { get; set; }
        public Nullable<System.TimeSpan> trajanje { get; set; }
        public Nullable<double> duzina { get; set; }
        public Nullable<int> tip_ture_id { get; set; }
        public Nullable<int> tezina { get; set; }
        public Nullable<bool> rent_bicikla { get; set; }
        public Nullable<int> zaposlenik_id { get; set; }
        public Nullable<int> klijent_id { get; set; }
    
        public virtual KLIJENTI KLIJENTI { get; set; }
        public virtual TIPOVI_TURA TIPOVI_TURA { get; set; }
        public virtual ZAPOSLENICI ZAPOSLENICI { get; set; }
    }
}
