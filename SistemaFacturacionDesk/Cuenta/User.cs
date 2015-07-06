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

                        user.IdUsuario = v.id;
                        user.IsAdmin = v.IsAdmin;
                    }

                    instance = user;
                }
            }
        } 
        #endregion

        public int IdUsuario;
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
