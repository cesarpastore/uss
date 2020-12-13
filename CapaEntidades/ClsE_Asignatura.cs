using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ClsE_Asignatura
    {
        public Int32 IdAsignatura { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
         public decimal   CantHoras { get; set; }
          public Int32    Creditos { get; set; }

    }
}
