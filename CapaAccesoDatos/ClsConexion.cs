using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaAccesoDatos
{
       public class ClsConexion
    {
        public SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BDMatriculaConnectionString"].ToString());
        SqlCommand cmd;
        DataSet Dset;
        SqlDataAdapter Adapter;
        public string[] Campo = new string[100];
        public string[] Valor = new string[100];
        public string[] BuscarCampo = new string[100];
        public DataTable Tabla;
        public DataSet DataSetR = new DataSet();

        public void Procedimiento(string NombreProcedimiento, int parametro)
        {
            //try

            cn.Open();
            SqlCommand cmd = new SqlCommand(NombreProcedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int i;
            for (i = 1; i <= parametro; i++)
            {
                cmd.Parameters.AddWithValue(Campo[i], Valor[i]);
            }
            cmd.ExecuteNonQuery();
            cn.Close();
            //Catch ex As Exception
            //    Throw New Exception("Contáctese con soporte técnico.")
            //End Try
        }

        public DataTable Listado(string NombreProcedimiento, int Parametro)
        {
            cn.Open();
            Dset = new DataSet();
            cmd = new SqlCommand();
            cmd = new SqlCommand(NombreProcedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
              int i;
            for (i = 1; i <= Parametro; i++)
            {
                cmd.Parameters.AddWithValue(Campo[i], Valor[i]);

            }
            Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(Dset, NombreProcedimiento);
            cn.Close();
            return Dset.Tables[0];
           
            //Catch ex As Exception
            //    Throw New Exception("Contáctese con soporte técnico.")
            //End Try

        }

        //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
        //public Tuple<Sri> ListadoConSalida(string NombreProcedimiento, int ParametroEntrada, int ParametroSalida) 

        //{
        //    //'Try
        //    int[] tlista = new int[];
        //    cmd = new SqlCommand(NombreProcedimiento, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    int i;
        //    for (i = 1; i <= ParametroEntrada; i++ +)
        //    {
        //        cmd.Parameters.AddWithValue(Campo[i], Valor[i]);
        //     }
        //    int i2;
        //    for (i2 = 1; i2 <= ParametroSalida; i++)
        //    {
        //        cmd.Parameters.Add(BuscarCampo[i2], SqlDbType.NChar);
        //        cmd.Parameters[BuscarCampo[i2]].Size = 300;
        //        cmd.Parameters[BuscarCampo[i2]].Direction = ParameterDirection.Output;
        //    }
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //    cn.Close();
        //    int i3;
        //    for (i3 = 1; i3 <= ParametroSalida; i3++)
        //    {
        //        lista.Add(cmd.Parameters[BuscarCampo[i3]].Value);
        //    }
        //return lista
        ////'Catch ex As Exception
        ////'    Throw New Exception("Contáctese con soporte técnico...")
        //}

    }

    

}

