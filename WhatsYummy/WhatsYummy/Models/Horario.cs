//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatsYummy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario
    {
        public int Dia { get; set; }
        public int EstabelecimentoId { get; set; }
        public System.TimeSpan HoraAbertura { get; set; }
        public System.TimeSpan HoraFecho { get; set; }
    
        public virtual Estabelecimento Estabelecimento { get; set; }

        public string convertDay(int d)
        {
            
            return "nada";
        }

    }


 
}
