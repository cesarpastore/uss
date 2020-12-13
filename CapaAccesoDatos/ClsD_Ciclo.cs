using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Ciclo
    {

        ClsE_Ciclo objECiclo = new ClsE_Ciclo();
        ClsConexion ObjClConexion = new ClsConexion();


      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarCiclo", 0);
        }

        public void D_Registrar( ClsE_Ciclo Enti)
        {
            ObjClConexion.Campo[1] = "@Ciclo";
            ObjClConexion.Valor[1] = Enti.Ciclo;
            ObjClConexion.Procedimiento("SpRegistrarCiclo", 1);
    }
        public void D_Moficiar(ClsE_Ciclo Enti)
        {
            ObjClConexion.Campo[1] = "@IdCiclo";
            ObjClConexion.Campo[2] = "@Ciclo";
              ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCiclo);
            ObjClConexion.Valor[2] = Enti.Ciclo;
           ObjClConexion.Procedimiento("SpModificarCiclo", 2);
        }
        public void D_Eliminar(ClsE_Ciclo Enti)
        {
           ObjClConexion.Campo[1] = "@IdCiclo";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCiclo);
            ObjClConexion.Procedimiento("SpEliminarCiclo", 1);
        }

        public DataTable D_Buscar(ClsE_Ciclo Enti)
        {
            ObjClConexion.Campo[1] = "@Ciclo";
            ObjClConexion.Valor[1] = Enti.Ciclo;
            return ObjClConexion.Listado("SpBuscarCiclo", 1);
        }
        public DataTable D_BuscarxId(ClsE_Ciclo Enti)
        {
            ObjClConexion.Campo[1] = "@IdCiclo";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCiclo);
            return ObjClConexion.Listado("SpBuscarCicloID", 1);
        }




    }
}
