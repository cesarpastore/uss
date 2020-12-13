using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class ClsN_Carrera
    {
        ClsD_Carrera objDatos = new ClsD_Carrera();
           public DataTable N_Listar()
        {
            return objDatos.D_Listar();
        }
        public DataTable N_Buscar(ClsE_Carrera enti )
        {
            return objDatos.D_Buscar(enti);
        }
    
       
        public void N_Registrar(ClsE_Carrera enti)
        {
            objDatos.D_Registrar(enti);
        }
        public void N_Modificar(ClsE_Carrera enti)
        {
             objDatos.D_Moficiar(enti);
        }
        public void N_Eliminar(ClsE_Carrera enti)
        {
             objDatos.D_Eliminar(enti);
        }
        public DataTable N_BuscarXId(ClsE_Carrera enti)
        {
            return objDatos.D_BuscarxId(enti);
        }

    }
 
}