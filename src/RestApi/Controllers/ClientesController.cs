using NSwag.Annotations;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace RestApi.Controllers
{
    /// <summary>
    /// Servicio de clientes
    /// </summary>
    public class ClientesController : ApiController
    {
        /// <summary>
        /// Obtiene todos los clientes
        /// </summary>
        /// <returns>Retorna un listado de clientes.</returns>
        [SwaggerResponse(typeof(ClienteResumenModelo[]))]
        public IHttpActionResult Get()
        {
            return Ok(new[] { new ClienteResumenModelo { Id = 1, Nombre = "Uno" } });
        }

        /// <summary>
        /// Obtiene un cliente identificado con el id.
        /// </summary>
        /// <param name="id">id del cliente a buscar</param>
        /// <returns>Retorna el cliente encontrado.</returns>
        [SwaggerResponse(typeof(ClienteDetalleModelo))]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(void), Description = "Si no existe ningun cliente con el id indicado.")]
        public IHttpActionResult Get(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            else
            {
                return Ok(new ClienteDetalleModelo { Id = id, Nombre = $"Cliente-{id}", EstaActivo = true, Fecha = DateTime.Now });
            }
        }

        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
        /// <param name="cliente">Datos del cliente a crear</param>
        /// <returns>Retorna el nuevo cliente creado</returns>
        [SwaggerResponse(HttpStatusCode.Created, typeof(ClienteDetalleModelo))]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(ModelStateDictionary))]
        public IHttpActionResult Post(ClienteCrearEditarModelo cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Created($"/api/clientes/1", new ClienteDetalleModelo { Id = 1, Nombre = $"Cliente-1", EstaActivo = true, Fecha = DateTime.Now });
            }
        }

        /// <summary>
        /// Actualiza la informaci&oacute;n de un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <param name="cliente">Nuevos datos para actualizar el cliente</param>
        /// <returns>Retorna OK si se logra actualizar el cliente</returns>
        [SwaggerResponse(HttpStatusCode.OK, typeof(void))]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(ModelStateDictionary))]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(void), Description = "Si no existe ningun cliente con el id indicado.")]
        public IHttpActionResult Put(int id, ClienteCrearEditarModelo cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        /// <summary>
        /// Elimina el cliente identificado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [SwaggerResponse(typeof(void))]
        [SwaggerResponse(HttpStatusCode.NotFound, typeof(void), Description = "Si no existe ningun cliente con el id indicado.")]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }
    }
}
