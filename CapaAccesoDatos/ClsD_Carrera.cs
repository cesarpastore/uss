using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Carrera
    {

        ClsE_Carrera objECarrera = new ClsE_Carrera();
        ClsConexion ObjClConexion = new ClsConexion();
      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarCarrera", 0);
        }

        public void D_Registrar( ClsE_Carrera Enti)
        {
            ObjClConexion.Campo[1] = "@Nombre";
            ObjClConexion.Campo[2] = "@Facultad"; 
            ObjClConexion.Valor[1] = Enti.Nombre;
            ObjClConexion.Valor[2] = Enti.Facultad;
     ObjClConexion.Procedimiento("SpRegistrarCarrera", 2);
    }
        public void D_Moficiar(ClsE_Carrera Enti)
        {
            ObjClConexion.Campo[1] = "@IdCarrera";
            ObjClConexion.Campo[2] = "@Nombre";
            ObjClConexion.Campo[3] = "@Facultad";
             ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCarrera);
            ObjClConexion.Valor[2] = Enti.Nombre;
            ObjClConexion.Valor[3] = Enti.Facultad;
                 ObjClConexion.Procedimiento("SpModificarCarrera", 3);
        }
        public void D_Eliminar(ClsE_Carrera Enti)
        {
           ObjClConexion.Campo[1] = "@IdCarrera";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCarrera);
            ObjClConexion.Procedimiento("SpEliminarCarrera", 1);
        }

        public DataTable D_Buscar(ClsE_Carrera Enti)
        {
            ObjClConexion.Campo[1] = "@Nombre";
            ObjClConexion.Valor[1] = Enti.Nombre;
            return ObjClConexion.Listado("SpBuscarCarrera", 1);
        }
        public DataTable D_BuscarxId(ClsE_Carrera Enti)
        {
            ObjClConexion.Campo[1] = "@IdCarrera";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdCarrera);
            return ObjClConexion.Listado("SpBuscarCarreraID", 1);
        }




    }
}
