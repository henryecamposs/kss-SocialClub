using ksslib_c.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kss_DataObjects.Entities
{
    /// <summary>
    /// User custom methods for usuarios
    /// </summary>
    partial class Usuarios
    {
        public Usuarios()
        {
            fecha_caduca = clsUtil_Strings.newDate();
            fecha_fin = clsUtil_Strings.newDate();
            fecha_inicio = clsUtil_Strings.newDate();
        }
        

    }

}
