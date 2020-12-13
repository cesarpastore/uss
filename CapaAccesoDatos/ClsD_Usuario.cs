using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
namespace CapaAccesoDatos
{
    public class ClsD_Usuario
    {

        ClsE_Usuario objEUsuario = new ClsE_Usuario();
        ClsConexion ObjClConexion = new ClsConexion();


      public DataTable D_Listar()
        { 
        return ObjClConexion.Listado("SpListarUsuario", 0);
        }

        public void D_Registrar( ClsE_Usuario Enti)
        {
            ObjClConexion.Campo[1] = "@Usuario";
            ObjClConexion.Campo[2] = "@Clave";
            ObjClConexion.Campo[3] = "@DNI";
            ObjClConexion.Campo[4] = "@Apellidos";
            ObjClConexion.Campo[5] = "@Nombres";
            ObjClConexion.Campo[6] = "@Perfil";
            ObjClConexion.Campo[7] = "@Telefono";
            ObjClConexion.Campo[8] = "@Email";
            ObjClConexion.Valor[1] = Enti.Usuario;
            ObjClConexion.Valor[2] = Enti.Clave;
            ObjClConexion.Valor[3] = Enti.DNI;
            ObjClConexion.Valor[4] = Enti.Apellidos;
            ObjClConexion.Valor[5] = Enti.Nombre;
            ObjClConexion.Valor[6] = Enti.Perfil;
            ObjClConexion.Valor[7] = Enti.Telefono;
            ObjClConexion.Valor[8] = Enti.Email;
            ObjClConexion.Procedimiento("SpRegistrarUsuario", 8);
    }
        public void D_Moficiar(ClsE_Usuario Enti)
        {
            ObjClConexion.Campo[1] = "@IdUsuario";
            ObjClConexion.Campo[2] = "@Usuario";
            ObjClConexion.Campo[3] = "@Clave";
            ObjClConexion.Campo[4] = "@DNI";
            ObjClConexion.Campo[5] = "@Apellidos";
            ObjClConexion.Campo[6] = "@Nombres";
            ObjClConexion.Campo[7] = "@Perfil";
            ObjClConexion.Campo[8] = "@Telefono";
            ObjClConexion.Campo[9] = "@Email";
            ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdUsuario);
            ObjClConexion.Valor[2] = Enti.Usuario;
            ObjClConexion.Valor[3] = Enti.Clave;
            ObjClConexion.Valor[4] = Enti.DNI;
            ObjClConexion.Valor[5] = Enti.Apellidos;
            ObjClConexion.Valor[6] = Enti.Nombre;
            ObjClConexion.Valor[7] = Enti.Perfil;
            ObjClConexion.Valor[8] = Enti.Telefono;
            ObjClConexion.Valor[9] = Enti.Email;
            ObjClConexion.Procedimiento("SpModificarUsuario", 8);
        }
        public void D_Eliminar(ClsE_Usuario Enti)
        {
           ObjClConexion.Campo[1] = "@IdUsuario";
           ObjClConexion.Valor[1] = System.Convert.ToString(Enti.IdUsuario);
            ObjClConexion.Procedimiento("SpEliminarUsuario", 1);
        }

        public DataTable D_Buscar(ClsE_Usuario Enti)

        {
            ObjClConexion.Campo[1] = "@Usuario";
            ObjClConexion.Valor[1] = Enti.Usuario;
            return ObjClConexion.Listado("SpBuscarUsuario", 1);
        }
        public DataTable D_BuscarClave(ClsE_Usuario Enti)
        {
            ObjClConexion.Campo[1] = "@Usuario";
            ObjClConexion.Valor[1] = Enti.Usuario;
            return ObjClConexion.Listado("SpBuscarClaveUsuario", 1);
        }

        //public Tuple<string, string, string, string> D_LoginUsuarioTupla(ClsE_Usuario enti)
        //{

        //    ObjClConexion.Campo[1] = "@Usuario";
        //    ObjClConexion.Valor[1] = enti.Usuario;
        //    ObjClConexion.BuscarCampo[1] = "@Password";
        //    ObjClConexion.BuscarCampo[2] = "@Perfil";
        //    ObjClConexion.BuscarCampo[3] = "@IdPersonal";
        //    ObjClConexion.BuscarCampo[4] = "@CambioPasword";
        //    ObjClConexion.BuscarCampo[5] = "@Estado";
        //    return ObjClConexion.ListadoConSalida("SpLoginUsuario", 1, 5);

        //}

        //public DataTable D_BuscarUsuario(ClsE_Usuario enti)
        //{
        //    cn.Open();
        //    cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "SpBuscarUsuario";
        //    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = enti.Usuario;
        //    cmd.Connection = cn;
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    cmd.ExecuteNonQuery();
        //    da.Fill(dt);
        //    return dt;
        //}
        //public void D_InsertarUsuario(ClsE_Usuario enti)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "SpRegistrarUsuario";
        //    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = enti.Usuario;
        //    cmd.Parameters.Add("@ClaveUsu", SqlDbType.Char).Value = enti.ClaveUsu;
        //    cmd.Parameters.Add("@PerfilUsu", SqlDbType.VarChar).Value = enti.PerfilUsu;
        //    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = enti.Nombre;
        //    cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = enti.Apellidos;
        //    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = enti.Email;
        //    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = enti.Telefono;
        //    cmd.Connection = cn;
        //    //try
        //    //    {
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //    //}
        //    //{
        //    //    catch ex As exception
        //    //        Throw ex
        //    //    Finally
        //    //        cn.Close()
        //    //        cn.Dispose()
        //    //}
        //}


        //public Tuple<string, string, string, string> D_LoginUsuarioTupla(ClsE_Usuario enti)
        //{
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "SpLoginUsuario";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = enti.Usuario;
        //    cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add("@Perfil", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
        //    cmd.ExecuteNonQuery();
        //    cn.Close();
        //    return Tuple.Create(Convert.ToString(cmd.Parameters["@Clave"].Value.ToString()), Convert.ToString(cmd.Parameters["@Nombres"].Value.ToString()), Convert.ToString(cmd.Parameters["@Apellidos"].Value.ToString()), Convert.ToString(cmd.Parameters["@Perfil"].Value.ToString()));
        //}

    }
}
