using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ClsE_Periodo
    { 
        public Int32 IdPeriodo { get; set; }
        public string Periodo { get; set; }
        public string FechaIni { get; set; }
        public string FechaFin { get; set; }
        public Int32 Editando { get; set; }


    }
}
