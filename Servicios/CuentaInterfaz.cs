using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarDeAlta.Dtos;

namespace DarDeAlta.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentran las Implementaciones donde se encuentran las copias de la lista CuentasDto.
    /// 221123 - chi
    /// </summary>
    internal interface CuentaInterfaz
    {
        /// <summary>
        /// Implementación donde se encuentra la copia de la lista CuentasDto.
        /// 171123 - chi
        /// </summary>
        public void nuevaCuenta(List<CuentasDto> cuentaAntigua);
    }
}
