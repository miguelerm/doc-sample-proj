using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace ServiciosWeb
{
    /// <summary>
    /// Servicio de usuarios de ejemplo
    /// </summary>
    [WebService(Namespace = "https://miguelerm.github.io/servicios/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class UsuariosServicio : WebService
    {

        [WebMethod(Description = "Obtiene todos los usuarios")]
        public UsuarioModelo[] ObtenerUsuarios()
        {
            return new UsuarioModelo[] { };
        }
    }
}
