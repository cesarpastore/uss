using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ClsE_Estudiante
    {
        public Int32 IdEstudiante { get; set; }
        public string Codigo { get; set; }
        public string DNI { get; set; }
         public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public DateTime FechNacimiento { get; set; }
        public int IdCarrera { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Int32 Editando { get; set; }
    }
}
