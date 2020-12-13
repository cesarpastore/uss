using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Asignatura
    {

        //ClsE_Asignatura objEAsignatura = new ClsE_Asignatura();
        ClsConexion ObjClConexion = new ClsConexion();


      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarAsignatura", 0);
        }

        public void D_Registrar(ClsE_Asignatura Enti)
        {
            ObjClConexion.Campo[1] = "@Codigo";
            ObjClConexion.Campo[2] = "@Nombre";
            ObjClConexion.Campo[3] = "@CantHoras";
            ObjClConexion.Campo[4] = "@Creditos";;
            ObjClConexion.Valor[1] = Enti.Codigo;
            ObjClConexion.Valor[2] = Enti.Nombre;
            ObjClConexion.Valor[3] = System.Convert.ToString(Enti.CantHoras);
            ObjClConexion.Valor[4] = System.Convert.ToString(Enti.Creditos);
            ObjClConexion.Procedimiento("SpRegistrarAsignatura", 4);
    }
        public void D_Moficiar(ClsE_Asignatura Enti)
        {
            ObjClConexion.Campo[1] = "@IdAsignatura";
            ObjClConexion.Campo[2] = "@Codigo";
            ObjClConexion.Campo[3] = "@Nombre";
            ObjClConexion.Campo[4] = "@CantHoras";
            ObjClConexion.Campo[5] = "@Creditos";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdAsignatura);
            ObjClConexion.Valor[2] = Enti.Codigo;
            ObjClConexion.Valor[3] = Enti.Nombre;
            ObjClConexion.Valor[4] = System.Convert.ToString(Enti.CantHoras);
            ObjClConexion.Valor[5] = System.Convert.ToString(Enti.Creditos);
            ObjClConexion.Procedimiento("SpModificarAsignatura", 5);
        }
        public void D_Eliminar(ClsE_Asignatura Enti)
        {
           ObjClConexion.Campo[1] = "@IdAsignatura";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdAsignatura);
            ObjClConexion.Procedimiento("SpEliminarAsignatura", 1);
        }

        public DataTable D_Buscar(ClsE_Asignatura Enti)
        {
            ObjClConexion.Campo[1] = "@Nombre";
            ObjClConexion.Valor[1] = Enti.Nombre;
            return ObjClConexion.Listado("SpBuscarAsignatura", 1);
        }
        public DataTable D_BuscarxId(ClsE_Asignatura Enti)
        {
            ObjClConexion.Campo[1] = "@IdAsignatura";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdAsignatura);
            return ObjClConexion.Listado("SpBuscarAsignaturaID", 1);
        }




    }
}
