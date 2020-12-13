using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Docente
    {

        //ClsE_Docente objEDocente = new ClsE_Docente();
        ClsConexion ObjClConexion = new ClsConexion();


      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarDocente", 0);
        }

        public void D_Registrar(ClsE_Docente Enti)
        {
             ObjClConexion.Campo[1] = "@DNI";
            ObjClConexion.Campo[2] = "@Apellidos";
            ObjClConexion.Campo[3] = "@Nombres";
            ObjClConexion.Campo[4] = "@Especialidad";
            ObjClConexion.Campo[5] = "@Telefono";
            ObjClConexion.Campo[6] = "@Email";
            ObjClConexion.Valor[1] = Enti.DNI;
            ObjClConexion.Valor[2] = Enti.Apellidos;
            ObjClConexion.Valor[3] = Enti.Nombres;
            ObjClConexion.Valor[4] = Enti.Especialidad;
            ObjClConexion.Valor[5] = Enti.Telefono;
            ObjClConexion.Valor[6] = Enti.Email;
            ObjClConexion.Procedimiento("SpRegistrarDocente", 6);
    }
        public void D_Moficiar(ClsE_Docente Enti)
        {
            ObjClConexion.Campo[1] = "@IdDocente";
            ObjClConexion.Campo[2] = "@DNI";
            ObjClConexion.Campo[3] = "@Apellidos";
            ObjClConexion.Campo[4] = "@Nombres";
            ObjClConexion.Campo[5] = "@Especialidad";
            ObjClConexion.Campo[6] = "@Telefono";
            ObjClConexion.Campo[7] = "@Email";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdDocente);
            ObjClConexion.Valor[2] = Enti.DNI;
            ObjClConexion.Valor[3] = Enti.Apellidos;
            ObjClConexion.Valor[4] = Enti.Nombres;
            ObjClConexion.Valor[5] = Enti.Especialidad;
            ObjClConexion.Valor[6] = Enti.Telefono;
            ObjClConexion.Valor[7] = Enti.Email;
            ObjClConexion.Procedimiento("SpModificarDocente", 7);
        }
        public void D_Eliminar(ClsE_Docente Enti)
        {
           ObjClConexion.Campo[1] = "@IdDocente";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdDocente);
            ObjClConexion.Procedimiento("SpEliminarDocente", 1);
        }

        public DataTable D_Buscar(ClsE_Docente Enti)
        {
            ObjClConexion.Campo[1] = "@Nombres";
            ObjClConexion.Valor[1] = Enti.Nombres;
            return ObjClConexion.Listado("SpBuscarDocente", 1);
        }
        public DataTable D_BuscarxId(ClsE_Docente Enti)
        {
            ObjClConexion.Campo[1] = "@IdDocente";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdDocente);
            return ObjClConexion.Listado("SpBuscarDocenteID", 1);
        }




    }
}
