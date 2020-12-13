using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class ClsN_Usuario
    {
        ClsD_Usuario objDatos = new ClsD_Usuario();
        //ClsE_Usuario objEnUsuario = new ClsE_Usuario();
        public DataTable N_ListarUsuario()
        {
            return objDatos.D_Listar();
        }
        public DataTable N_BuscarUsuario(ClsE_Usuario enti )
        {
            return objDatos.D_Buscar(enti);
        }
    
        public DataTable N_BuscarClave(ClsE_Usuario enti)
        {
            return objDatos.D_BuscarClave(enti);
        }
        public void N_Regstrar(ClsE_Usuario enti)
        {
            objDatos.D_Registrar(enti);
        }
        public void N_Modificar(ClsE_Usuario enti)
        {
             objDatos.D_Moficiar(enti);
        }
        public void N_Eliminar(ClsE_Usuario enti)
        {
             objDatos.D_Eliminar(enti);
        }
        //public Tuple<string, string, string, string>  N_LoginUsuarioTupla(ClsE_Usuario enti)
        //   {
        //       return objDatos.D_LoginUsuarioTupla(enti);
        //   }

        //   public void N_InsertarUsuario(ClsE_Usuario enti)
        //   {
        //       objDatos.D_InsertarUsuario(enti);
        //   }

    }
 
}