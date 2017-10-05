namespace Libreria
{
    /// <summary>
    /// Clase de ejemplo
    /// </summary>
    public class MiClase
    {
        /// <summary>
        /// Método de ejemplo
        /// </summary>
        /// <param name="id">Identificador de ejemplo</param>
        /// <param name="nombre">Nombre de ejemplo</param>
        /// <returns>Una instancia de <see cref="MiModelo"/> con id y nombre.</returns>
        public MiModelo MiMetodo(int id, string nombre)
        {
            return new MiModelo { Id = id, Nombre = nombre };
        }
    }
}
