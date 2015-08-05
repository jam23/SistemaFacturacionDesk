using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionDesk
{
    public sealed class User
    {

        #region SingleOn
        private static User instance;
        private static readonly object locker = new object();
        private User()
        {
            IdUsuario = 0;
        }
        public static void IniciarSesion(int UserId)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    var user = new User();

                    using (EntitiesFACTURACION db = new EntitiesFACTURACION())
                    {
                        var v = db.VENDEDORES.Find(UserId); // Buscar el usuario que se esta logeando.
                       
                        user.Nombres = v.nombres;
                        user.Apellido1 = v.apellido1;
                        user.Apellido2 = v.apellido2;
                        user.IdUsuario = v.id;
                        user.IsAdmin = v.IsAdmin;
                    }

                    instance = user;
                }
            }
        }

        public static void CerrarSesion()
        {
            instance = null;
        }

        #endregion

        public int IdUsuario;
        public string Nombres;
        public string Apellido1;
        public string Apellido2;
        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", Nombres, Apellido1, Apellido2);
            }
        }
        public bool IsAdmin;
        public static User UsuarioLogeado
        {
            get
            {
                return instance;
            }

        }

    }
}
