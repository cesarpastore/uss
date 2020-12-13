using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaEntidades
{
    public class ClsE_Usuario
    {
        public Int32 IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Perfil { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
         public string UsuarioAcceso { get; set; }
        public string PerfilUsuarioAcceso { get; set; }
        public string NombreUsuarioAcceso { get; set; }
       


    }
}