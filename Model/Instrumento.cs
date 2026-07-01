using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    internal class Instrumento
    {
        public string nombre { get; set; }
        public string categoria { get; set; } // (Cuerda / Viento / Percusión / Teclado)
        public string marca { get; set; }
        public int codigo { get; set; }
        public bool disponible { get; set; }


    }
}
