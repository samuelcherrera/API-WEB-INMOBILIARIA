//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_WEB_INMOBILIARIA.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_orden
    {
        public int id_detalle { get; set; }
        public int id_orden { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio_unitario { get; set; }

        [JsonIgnore]
        public virtual orden_compra orden_compra { get; set; }
    }
}
