using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionDesk.Cuenta
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
                    user.IdUsuario = UserId;
                    instance = user;
                }
            }
        } 
        #endregion

        public int IdUsuario;
        public static User UsuarioLogeado
        {
            get
            {
                return instance;
            }

        }
        
    }
}
