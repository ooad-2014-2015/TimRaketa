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
    
    public partial class TIPOVI_USLUGA
    {
        public TIPOVI_USLUGA()
        {
            this.STAVKE_KORPE = new HashSet<STAVKE_KORPE>();
        }
    
        public int tip_usluge_id { get; set; }
        public string tip_usluge { get; set; }
    
        public virtual ICollection<STAVKE_KORPE> STAVKE_KORPE { get; set; }
    }
}
