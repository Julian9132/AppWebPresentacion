using System;
using System.Collections.Generic;

#nullable disable

namespace AppBootstrap.Models
{
    public partial class Cliente
    {
        public uint Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}
