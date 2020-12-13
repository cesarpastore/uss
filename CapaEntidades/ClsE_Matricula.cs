using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ClsE_Matricula
    {


        //Reserva matricula
        public Int32 IdMatricula { get; set; }
        public string Fecha { get; set; }
        public Int32 IdPeriodo { get; set; }
        public Int32 IdEstudiante { get; set; }
        public decimal Pago { get; set; }
         public Int32 IdUsuario { get; set; }
        //Detalle
        public Int32 Item { get; set; }
        public Int32 IdAginatura { get; set; }
        public Int32 IdCiclo { get; set; }
        public Int32 Vez { get; set; }
        public Int32 IdDocente { get; set; }
    }
}
