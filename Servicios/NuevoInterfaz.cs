using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
/// <summary>
/// Interfaz donde se encuentran las Implementaciones donde se encuentran las copias de la lista ClienteDto.
/// 281123 - chi
/// </summary>
{
    internal interface NuevoInterfaz
    {
        /// <summary>
        /// Implementación donde se encuentra la copia de la lista ClienteDto.
        /// 171123 - chi
        /// </summary>
        public void darAltaCliente(List<ClientesDto> listaAntigua);

        /// <summary>
        /// Implementación donde se encuentra la copia de la lista ClienteDto.
        /// 281123 - chi
        /// </summary>
        public void borrarCliente(List<ClientesDto> listaAntigua);

        /// <summary>
        /// Implementación donde se encuentra la copia de la lista ClienteDto.
        /// 281123 - chi
        /// </summary>
        public void modificarCliente(List<ClientesDto> listaAntigua);
    }
}
