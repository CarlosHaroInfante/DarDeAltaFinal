using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Interfaz donde se encontrará el menú.
        /// 171123 - chi
        /// </summary>
        public int menu();

        /// <summary>
        /// Interfaz donde se pedirá el dni.
        /// 281123 - chi
        /// </summary>
        public string pedirDNI();

        /// <summary>
        /// Interfaz donde se encontrará el menú de modificación del usuario.
        /// 281123 - chi
        /// </summary>
        public int seleccion();
    }
}
