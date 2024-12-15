using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novena.Modelo
{
    public class AsistenciaView
    {
        public int Id_Asistencia { get; set; }
        public int id_kid { get; set; }
        public string Nombre_Completo { get; set; }
        public int edad {  get; set; }  
        public bool Day1 { get; set; }
        public bool Day2 { get; set; }
        public bool Day3 { get; set; }
        public bool Day4 { get; set; }
        public bool Day5 { get; set; }
        public bool Day6 { get; set; }
        public bool Day7 { get; set; }
        public bool Day8 { get; set; }
        public bool Day9 { get; set; }

    }
}
