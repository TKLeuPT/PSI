//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Surf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int NumReserva { get; set; }
        public int NumCliente { get; set; }
        public System.DateTime DatEntrada { get; set; }
        public System.DateTime DatSaida { get; set; }
        public int NumAdultos { get; set; }
        public int NumCriancas { get; set; }
        public int NumBungRes { get; set; }
    
        public virtual Bungalow Bungalow { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
