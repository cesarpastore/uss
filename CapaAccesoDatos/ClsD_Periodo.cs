
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClsD_Periodo
    {

        ClsE_Ciclo objECiclo = new ClsE_Ciclo();
        ClsConexion ObjClConexion = new ClsConexion();


      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarPeriodo", 0);
        }

        public void D_Registrar( ClsE_Periodo Enti)
        {
            ObjClConexion.Campo[1] = "@Periodo";
            ObjClConexion.Campo[2] = "@FechaIni";
            ObjClConexion.Campo[2] = "@FechaFin";
            ObjClConexion.Valor[1] = Enti.Periodo;
            ObjClConexion.Valor[2] = Enti.FechaIni;
            ObjClConexion.Valor[2] = Enti.FechaFin;
            ObjClConexion.Procedimiento("SpRegistrarPeriodo", 3);
    }
        public void D_Moficiar(ClsE_Periodo Enti)
        {
            ObjClConexion.Campo[1] = "@IdPeriodo";
            ObjClConexion.Campo[2] = "@Periodo";
            ObjClConexion.Campo[3] = "@FechaIni";
            ObjClConexion.Campo[4] = "@FechaFin";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdPeriodo);
            ObjClConexion.Valor[2] = Enti.Periodo;
            ObjClConexion.Valor[3] = Enti.FechaIni;
            ObjClConexion.Valor[4] = Enti.FechaFin;
            ObjClConexion.Procedimiento("SpModificarCiclo", 4);
        }
        public void D_Eliminar(ClsE_Periodo Enti)
        {
           ObjClConexion.Campo[1] = "@IdPeriodo";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdPeriodo);
            ObjClConexion.Procedimiento("SpEliminarPeriodo", 1);
        }

        public DataTable D_Buscar(ClsE_Periodo Enti)
        {
            ObjClConexion.Campo[1] = "@Periodo";
            ObjClConexion.Valor[1] = Enti.Periodo;
            return ObjClConexion.Listado("SpBuscarPeriodo", 1);
        }
        public DataTable D_BuscarxId(ClsE_Periodo Enti)
        {
            ObjClConexion.Campo[1] = "@IdPeriodo";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdPeriodo);
            return ObjClConexion.Listado("SpBuscarPeriodoID", 1);
        }




    }
}
