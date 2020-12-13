﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class ClsN_Docente
    {
        ClsD_Docente objDatos = new ClsD_Docente();
           public DataTable N_Listar()
        {
            return objDatos.D_Listar();
        }
        public DataTable N_Buscar(ClsE_Docente enti )
        {
            return objDatos.D_Buscar(enti);
        }
    
       
        public void N_Registrar(ClsE_Docente enti)
        {
            objDatos.D_Registrar(enti);
        }
        public void N_Modificar(ClsE_Docente enti)
        {
             objDatos.D_Moficiar(enti);
        }
        public void N_Eliminar(ClsE_Docente enti)
        {
             objDatos.D_Eliminar(enti);
        }
        public DataTable N_BuscarXId(ClsE_Docente enti)
        {
            return objDatos.D_BuscarxId(enti);
        }

    }
 
}