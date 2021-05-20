using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actores;
using AcccesoDatos;

namespace ReglasNegocio
{
    public class GestorAdministradores
    {
         DataAdministradores GestorADM = new DataAdministradores();

        public bool Registrar(Administradores administradores)
        {
            return GestorADM.RegistrarAdmin(administradores);
        }
        public bool IsEmpty(Administradores administradores)
        {
            if (administradores.nombre.Equals("") || administradores.contraseña.Equals(""))

            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
