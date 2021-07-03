using System;
using System.Collections.Generic;

#nullable disable

namespace AppBootstrap.Models
{
    public partial class Usuario
    {
        public uint id { get; set; }

        public string nombre { get; set; }

        public string apodo{ get; set; }

        public string clave { get; set; }

        public string Rol { get; set; }
    }
    
}