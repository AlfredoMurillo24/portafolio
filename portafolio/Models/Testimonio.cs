//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portafolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Testimonio
    {
        public string id { get; set; }
        public string UsuarioId { get; set; }
        public string IP { get; set; }
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}