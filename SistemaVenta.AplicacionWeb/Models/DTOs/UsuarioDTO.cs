﻿using SistemaVenta.Entity;

namespace SistemaVenta.AplicacionWeb.Models.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public int IdCompany { get; set; }
        public string? Nombre { get; set; }

        public string? Correo { get; set; }

        public string? Telefono { get; set; }

        public int? IdRol { get; set; }

        public string? nombreRol { get; set; }

        public string? UrlFoto { get; set; }

        public int? EsActivo { get; set; }

    }
}
