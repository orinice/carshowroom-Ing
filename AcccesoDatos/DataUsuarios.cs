using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Actores;
using System.Configuration;

namespace AcccesoDatos
{
    public class DataUsuarios
    {
        SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=proyecto_final;Data Source=DESKTOP-OJN6LP8\SQLEXPRESS01");
        public bool Registrar(Usuarios usuario)

        {
            try
            {

                bool existe = false;
                string respuesta = "";



                SqlCommand cmd = new SqlCommand("USP_Registrar", cn);



                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", usuario.nombre);
                cmd.Parameters.Add("@contraseña", usuario.contraseña);
                cmd.Parameters.Add("@correo", usuario.correo);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    respuesta = dr["respuesta"].ToString();
                    cn.Close();
                }


                if (respuesta.Equals("true"))
                {
                    existe = true;
                }

                return existe;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }
    }
}
