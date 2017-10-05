using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class ClienteCrearEditarModelo
    {
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}