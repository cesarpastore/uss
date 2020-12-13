using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Estudiante
    {

         ClsConexion ObjClConexion = new ClsConexion();
      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarEstudiante", 0);
        }

        public void D_Registrar(ClsE_Estudiante Enti)
        {
            ObjClConexion.Campo[1] = "@Codigo";
            ObjClConexion.Campo[2] = "@DNI";
            ObjClConexion.Campo[3] = "@Apellidos";
            ObjClConexion.Campo[4] = "@Nombres";
            ObjClConexion.Campo[5] = "@Sexo";
            ObjClConexion.Campo[6] = "@FechNacimiento";
            ObjClConexion.Campo[7] = "@IdCarrera";
            ObjClConexion.Campo[8] = "@Telefono";
            ObjClConexion.Campo[9] = "@Email";
            ObjClConexion.Valor[1] = Enti.Codigo;
            ObjClConexion.Valor[2] = Enti.DNI;
            ObjClConexion.Valor[3] = Enti.Apellidos;
            ObjClConexion.Valor[4] = Enti.Nombres;
            ObjClConexion.Valor[5] = Enti.Sexo;
            ObjClConexion.Valor[6] =Convert.ToString( Enti.FechNacimiento);
            ObjClConexion.Valor[7] = Convert.ToString(Enti.IdCarrera);
            ObjClConexion.Valor[8] = Enti.Telefono;
            ObjClConexion.Valor[9] = Enti.Email;
            ObjClConexion.Procedimiento("SpRegistrarEstudiante", 9);
    }
        public void D_Moficiar(ClsE_Estudiante Enti)
        {
            ObjClConexion.Campo[1] = "@IdEstudiante";
            ObjClConexion.Campo[2] = "@Codigo";
            ObjClConexion.Campo[3] = "@DNI";
            ObjClConexion.Campo[4] = "@Apellidos";
            ObjClConexion.Campo[5] = "@Nombres";
            ObjClConexion.Campo[6] = "@Sexo";
            ObjClConexion.Campo[7] = "@FechNacimiento";
            ObjClConexion.Campo[8] = "@IdCarrera";
            ObjClConexion.Campo[9] = "@Telefono";
            ObjClConexion.Campo[10] = "@Email";
            ObjClConexion.Valor[1] = Convert.ToString(Enti.IdEstudiante);
            ObjClConexion.Valor[2] = Enti.Codigo;
            ObjClConexion.Valor[3] = Enti.DNI;
            ObjClConexion.Valor[4] = Enti.Apellidos;
            ObjClConexion.Valor[5] = Enti.Nombres;
            ObjClConexion.Valor[6] = Enti.Sexo;
            ObjClConexion.Valor[7] = Convert.ToString( Enti.FechNacimiento);
            ObjClConexion.Valor[8] = Convert.ToString(Enti.IdCarrera);
            ObjClConexion.Valor[9] = Enti.Telefono;
            ObjClConexion.Valor[10] = Enti.Email;
            ObjClConexion.Procedimiento("SpModificarEstudiante", 10);
        }
        public void D_Eliminar(ClsE_Estudiante Enti)
        {
           ObjClConexion.Campo[1] = "@IdEstudiante";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdEstudiante);
            ObjClConexion.Procedimiento("SpEliminarEstudiante", 1);
        }

        public DataTable D_Buscar(ClsE_Estudiante Enti)
        {
            ObjClConexion.Campo[1] = "@Nombres";
            ObjClConexion.Valor[1] = Enti.Nombres;
            return ObjClConexion.Listado("SpBuscarEstudiante", 1);
        }
        public DataTable D_BuscarxId(ClsE_Estudiante Enti)
        {
            ObjClConexion.Campo[1] = "@IdEstudiante";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdEstudiante);
            return ObjClConexion.Listado("SpBuscarEstudianteID", 1);
        }




    }
}
