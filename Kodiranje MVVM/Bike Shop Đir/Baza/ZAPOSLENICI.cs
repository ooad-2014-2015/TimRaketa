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
    
    public partial class ZAPOSLENICI
    {
        public ZAPOSLENICI()
        {
            this.KATALOG_TURA = new HashSet<KATALOG_TURA>();
        }
    
        public int zaposlenik_id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public Nullable<System.DateTime> datum_rodjenja { get; set; }
        public string adresa_stanovavnja { get; set; }
        public Nullable<System.TimeSpan> satnica { get; set; }
        public Nullable<double> plata { get; set; }
        public Nullable<int> tip_zaposlenika_id { get; set; }
    
        public virtual ICollection<KATALOG_TURA> KATALOG_TURA { get; set; }
        public virtual TIPOVI_ZAPOSLENIKA TIPOVI_ZAPOSLENIKA { get; set; }
    }
}
