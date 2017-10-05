using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class ClienteDetalleModelo
    {
        /// <summary>
        /// Ide del cliente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Fecha de registro
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public bool EstaActivo { get; set; }

    }
}