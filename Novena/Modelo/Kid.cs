using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novena.Modelo
{
    public class Kid
    {
       
        public int Id_Kid { get; set; }

        public string Primer_Nombre { get; set; }

        public string Segundo_Nombre { get; set; }

        public string Primer_Apellido { get; set; }

        public string Segundo_Apellido { get; set; }

        public string Edad { get; set; }

        public string Sexo { get; set; }

    }
}
